namespace foodiestopia.DTOs.User
{
    public record OwnerUserDTO
    (
        Guid Id,
        string Username,
        string Email,
        string Role
    );
}
