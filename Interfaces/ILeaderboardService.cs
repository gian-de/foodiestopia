using foodiestopia.DTOs.Leaderboard;
using foodiestopia.DTOs.Recipe;
using foodiestopia.Helpers;

namespace foodiestopia.Interfaces
{
    public interface ILeaderboardService
    {
        Task<LeaderboardPagedResult<RecipeSummaryDTO>> GetTop100RecipesAsync(int page, int pageSize);
        Task<LeaderboardPagedResult<UserLeaderboardStatsDTO>> GetTop100UsersAsync(int page, int pageSize);
    }
}