using _1.DAL.Configurations;
using _1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Context
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DatabaseContext()
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new EmployeeConfigguration()); 
        //    //chỗ này truyền configuration 
        //    modelBuilder.ApplyConfiguration(new OderConfiguration()); 
        //    modelBuilder.ApplyConfiguration(new CustomerConfiguration()); 
        //    modelBuilder.ApplyConfiguration(new OderDetailConfiguration()); 
        //    modelBuilder.ApplyConfiguration(new ProducerConfiguration());  
        //    modelBuilder.ApplyConfiguration(new ProductConfiguration()); 
        //    modelBuilder.ApplyConfiguration(new ImportHistoryConfiguration());   
        //    //modelBuilder.ApplyConfiguration(new ProductInProducerConfiguration());  

        //    //modelBuilder.Seed(); //gọi cái này để seeding data
        //}
        //chỗ này truyền các table
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Order> Oders { get; set; } 
        public DbSet<OrderDetail> OderDetails { get; set; } 
        public DbSet<Producer> Producers { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<ImportHistory> ImportHistories { get; set; }
        //public DbSet<ProductInEmployee> ProductInEmployees { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //lưu ý chỉ cần thay tên  ở Data Source= tên servername ở máy tính của bạn và phần catalog là tên đb bạn muốn đặt
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-JNDR021\SQLEXPRESS;Database=databaseDuAn1;Trusted_Connection=True;");

            }
        }
    }
}
