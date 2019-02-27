using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VueProject.MultiTenancy.Dto;

namespace VueProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

