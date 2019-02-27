using System.Threading.Tasks;
using Abp.Application.Services;
using VueProject.Authorization.Accounts.Dto;

namespace VueProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
