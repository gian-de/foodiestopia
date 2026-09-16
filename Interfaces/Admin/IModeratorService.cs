using foodiestopia.DTOs.Admin.Moderator;
using foodiestopia.DTOs.Playlist;
using foodiestopia.DTOs.Recipe;
using foodiestopia.Helpers;

namespace foodiestopia.Interfaces.Admin
{
    public interface IModeratorService
    {
        Task<PagedResult<RecipeSummaryDTO>> GetAllRecipePendingSubmissionsAsync(int page, int pageSize, string? username);
        Task<ModeratorSubmissionResponseDTO> RecipeSubmissionReviewAsync(Guid adminId, Guid recipeId, ModeratorSubmissionReviewDTO recipeReviewDTO);

        Task<PagedResult<PlaylistSummaryDTO>> GetAllPlaylistPendingSubmissionsAsync(int page, int pageSize, string? username);
        Task<ModeratorSubmissionResponseDTO> PlaylistSubmissionReviewAsync(Guid adminId, Guid playlistId, ModeratorSubmissionReviewDTO playlistReviewDTO);
    }
}