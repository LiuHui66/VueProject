using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using VueProject.Configuration;
using VueProject.Web;

namespace VueProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VueProjectDbContextFactory : IDesignTimeDbContextFactory<VueProjectDbContext>
    {
        public VueProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VueProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VueProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VueProjectConsts.ConnectionStringName));

            return new VueProjectDbContext(builder.Options);
        }
    }
}
