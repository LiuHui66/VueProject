using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VueProject.EntityFrameworkCore
{
    public static class VueProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VueProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VueProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
