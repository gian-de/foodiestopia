using foodiestopia.DTOs.User;
using foodiestopia.Helpers;

namespace foodiestopia.Interfaces.Admin
{
    public interface ISeniorAdminService
    {
        Task<PagedResult<UserInfoDTO>> GetAllBothSeniorAndAdminsAsync(int page, int pageSize);
        Task<PagedResult<UserInfoDTO>> GetAllSeniorAdminsAsync(int page, int pageSize);
        Task<PagedResult<UserInfoDTO>> GetAllNonSeniorAdminsAsync(int page, int pageSize);
        Task<UserInfoDTO> PromoteToAdminRoleAsync(Guid userId);
        Task<UserInfoDTO> DemoteToUserRoleAsync(Guid userId);
    }
}