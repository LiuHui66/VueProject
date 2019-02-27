using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VueProject.Configuration;

namespace VueProject.Web.Host.Startup
{
    [DependsOn(
       typeof(VueProjectWebCoreModule))]
    public class VueProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VueProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VueProjectWebHostModule).GetAssembly());
        }
    }
}
