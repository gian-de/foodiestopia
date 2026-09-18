# Foodiestopia API — DigitalOcean droplet (not Fly.io)

This repo is the ASP.NET Core API (`github.com/gian-de/foodiestopia`).
The Nuxt client is a separate repo: `github.com/gian-de/client-foodiestopia`.

Fly.io is **not** used. Local Docker Compose is unchanged (`docker compose up` still maps API `5001→8080` and Postgres `5432` on the host). Production on the droplet uses `docker-compose.prod.yml` (Postgres is **not** published).

## Connect from Cursor / VS Code (your Mac)

Host = the droplet public IPv4, user `root`, identity `~/.ssh/id_rsa`.

1. Install the **Remote - SSH** extension (`anysphere.remote-ssh` in Cursor, or `ms-vscode-remote.remote-ssh` in VS Code).
2. Confirm the Mac key works in a terminal:

   ```bash
   ssh -i ~/.ssh/id_rsa root@DROPLET_IP
   ```

3. Append this to `~/.ssh/config` (replace `DROPLET_IP`):

   ```sshconfig
   Host foodiestopia-api
     HostName DROPLET_IP
     User root
     IdentityFile ~/.ssh/id_rsa
     IdentitiesOnly yes
   ```

4. In Cursor/VS Code: Command Palette → **Remote-SSH: Connect to Host…** → `foodiestopia-api`.
5. After the window reloads, open the cloned repo (for example `/root/foodiestopia`).

## DNS

`foodiestopia.com` currently resolves to Squarespace (`198.185.159.*` / `198.49.23.*`). `api.foodiestopia.com` does **not** exist yet.

In the Squarespace (or registrar) DNS panel for `foodiestopia.com`, create:

| Type | Name | Value | TTL |
| ---- | ---- | ----- | --- |
| A    | `api` | droplet public IPv4 | 300 or auto |

That makes `api.foodiestopia.com` point at this droplet. Do **not** open Postgres `5432` in the cloud firewall.

Check DNS, then TLS:

```bash
dig +short api.foodiestopia.com
curl -I http://DROPLET_IP/api/countries
curl https://api.foodiestopia.com/api/countries
```

## First boot on the droplet

SSH in, install Docker Engine + Compose plugin if missing, clone this repo, then:

```bash
cd /root/foodiestopia   # or wherever you cloned
bash deploy/droplet-bootstrap.sh   # 2 GB swap + UFW 22/80/443, deny 5432
cp .env.example .env
nano .env   # set JWT_SIGNING_KEY, POSTGRES_PASSWORD, Gmail, seed passwords
```

`.env` on the droplet should look like:

```env
JWT_ISSUER=https://api.foodiestopia.com
JWT_AUDIENCE=https://foodiestopia.com
BASE_URL=https://api.foodiestopia.com
FRONTEND_URL=http://localhost:3000
JWT_SIGNING_KEY=<long random secret, never given to the client>
POSTGRES_PASSWORD=<strong password>
```

CORS already allows `http://localhost:3000`, `https://foodiestopia.com`, and `https://www.foodiestopia.com`. `FRONTEND_URL` is the origin used in email links; keep it `http://localhost:3000` until the Nuxt site is on `foodiestopia.com`.

Until the `api` A record exists, serve HTTP on port 80:

```bash
CADDYFILE=./deploy/Caddyfile.http docker compose -f docker-compose.prod.yml up -d --build
```

After DNS points at the droplet, switch to TLS (Caddy + Let’s Encrypt for **api.foodiestopia.com** only):

```bash
unset CADDYFILE
docker compose -f docker-compose.prod.yml up -d
```

Insider API port is `8080`; Caddy publishes `80`/`443`. Postgres stays on the Compose network.

Destroy leftover Fly apps on your machine if they still exist (optional, needs Fly auth):

```bash
fly apps destroy foodiestopia-backend
fly apps destroy foodtopia-backend
```

GitHub Actions no longer deploys. Pushing `main` only **builds** the Docker image in CI.

## Local Nuxt → this API

In `client-foodiestopia`, copy `.env.example` to `.env`:

```env
BASE_API_URL=https://api.foodiestopia.com
```

Until DNS/TLS: `BASE_API_URL=http://DROPLET_IP`.

JWT login: `POST /api/account/login`, then Insomnia header `Authorization: Bearer <token>`. The signing key stays on the API/.env only.
