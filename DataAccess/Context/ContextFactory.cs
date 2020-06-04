using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TeatchersAndCourses.DataAccess.Context;

namespace StoreOfBuild.Data.Contexts
{
    public class ContextFactory : IDesignTimeDbContextFactory<TeatchersAndCoursesContext>
    {
        public TeatchersAndCoursesContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var builder = new DbContextOptionsBuilder<TeatchersAndCoursesContext>();

            var connectionString = configuration.GetConnectionString("TeatchersAndCourses");

            builder.UseSqlServer(connectionString);

            return new TeatchersAndCoursesContext(builder.Options);
        }

    }
}