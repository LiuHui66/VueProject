using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VueProject.Controllers
{
    public abstract class VueProjectControllerBase: AbpController
    {
        protected VueProjectControllerBase()
        {
            LocalizationSourceName = VueProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
