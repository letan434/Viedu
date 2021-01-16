using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ViEdu.Data.EF
{
    public class ViEduDbContextFactory : IDesignTimeDbContextFactory<ViEduDbContext>
    {

        public ViEduDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
            var connectionString = configuration.GetConnectionString("ViEduDbContext");
            var optionsBuilder = new DbContextOptionsBuilder<ViEduDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new ViEduDbContext(optionsBuilder.Options);
        }
    }
}
    