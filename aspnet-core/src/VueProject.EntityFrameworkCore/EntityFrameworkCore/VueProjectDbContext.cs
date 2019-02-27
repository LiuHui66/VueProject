using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VueProject.Authorization.Roles;
using VueProject.Authorization.Users;
using VueProject.MultiTenancy;

namespace VueProject.EntityFrameworkCore
{
    public class VueProjectDbContext : AbpZeroDbContext<Tenant, Role, User, VueProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VueProjectDbContext(DbContextOptions<VueProjectDbContext> options)
            : base(options)
        {
        }
    }
}
