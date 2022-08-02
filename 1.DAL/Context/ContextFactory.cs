using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        //public DatabaseContext CreateDbContext(string[] args)
        //{
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory()) //phải cài thêm fileExtensions
        //        .AddJsonFile("appsettings.json")  //phải cài thêm extension config json
        //        .Build();

        //    var connectionString = configuration.GetConnectionString("DuAn1Database");

        //    var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
        //    optionsBuilder.UseSqlServer(connectionString);

        //    return new DatabaseContext(optionsBuilder.Options);
        //}
    }
}
