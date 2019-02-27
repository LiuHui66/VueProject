using System.Threading.Tasks;
using VueProject.Configuration.Dto;

namespace VueProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
