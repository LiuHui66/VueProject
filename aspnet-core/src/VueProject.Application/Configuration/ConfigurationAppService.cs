using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VueProject.Configuration.Dto;

namespace VueProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VueProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
