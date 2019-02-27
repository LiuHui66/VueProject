using Microsoft.AspNetCore.Antiforgery;
using VueProject.Controllers;

namespace VueProject.Web.Host.Controllers
{
    public class AntiForgeryController : VueProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
