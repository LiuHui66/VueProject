using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VueProject.Authorization;

namespace VueProject
{
    [DependsOn(
        typeof(VueProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VueProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VueProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VueProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
