using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VueProject.Roles.Dto;
using VueProject.Users.Dto;

namespace VueProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
