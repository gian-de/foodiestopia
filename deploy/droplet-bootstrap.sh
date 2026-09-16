#!/usr/bin/env bash
# Idempotent first-boot extras for the 1 GB DigitalOcean droplet.
# Run as root: bash deploy/droplet-bootstrap.sh
set -euo pipefail

SWAPFILE=/swapfile
SWAP_SIZE=2G

if ! swapon --show | grep -q "$SWAPFILE"; then
  if [[ ! -f "$SWAPFILE" ]]; then
    fallocate -l "$SWAP_SIZE" "$SWAPFILE" || dd if=/dev/zero of="$SWAPFILE" bs=1M count=2048
    chmod 600 "$SWAPFILE"
    mkswap "$SWAPFILE"
  fi
  swapon "$SWAPFILE"
fi

if ! grep -q "$SWAPFILE" /etc/fstab; then
  echo "$SWAPFILE none swap sw 0 0" >> /etc/fstab
fi

if command -v ufw >/dev/null 2>&1; then
  ufw allow OpenSSH
  ufw allow 80/tcp
  ufw allow 443/tcp
  ufw deny 5432/tcp
  ufw --force enable
fi

echo "Swap:"
swapon --show
free -h
echo "UFW:"
ufw status || true
