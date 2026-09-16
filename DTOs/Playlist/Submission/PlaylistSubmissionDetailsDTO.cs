using foodiestopia.DTOs.Recipe;
using foodiestopia.DTOs.User;

namespace foodiestopia.DTOs.Playlist.Submission
{
    public record PlaylistSubmissionDetailsDTO
    (
        Guid PlaylistId,
        string Name,
        string FullSlug,
        DateTime CreatedAt,
        string VisibilityStatus,
        int HeartedByCount,
        int RecipeCount,
        DateTime? SubmittedAt,
        DateTime? ReviewedAt,
        string? ReviewedByUsername,
        UserTldrDTO User,
        List<RecipeTldrDTO> Recipes
    );
}