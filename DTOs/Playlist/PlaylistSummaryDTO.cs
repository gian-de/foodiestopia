using foodiestopia.DTOs.Recipe;
using foodiestopia.DTOs.User;

namespace foodiestopia.DTOs.Playlist
{
    public record PlaylistSummaryDTO
    (
        Guid Id,
        string Name,
        string FullSlug,
        DateTime CreatedAt,
        string VisibilityStatus,
        int HeartedByCount,
        int RecipeCount,
        UserTldrDTO User,
        List<RecipeTldrDTO>? Recipes
    );
}