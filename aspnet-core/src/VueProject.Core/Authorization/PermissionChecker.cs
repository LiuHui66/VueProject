using Abp.Authorization;
using VueProject.Authorization.Roles;
using VueProject.Authorization.Users;

namespace VueProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
