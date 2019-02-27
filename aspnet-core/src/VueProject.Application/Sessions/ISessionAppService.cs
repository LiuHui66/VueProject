using System.Threading.Tasks;
using Abp.Application.Services;
using VueProject.Sessions.Dto;

namespace VueProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
