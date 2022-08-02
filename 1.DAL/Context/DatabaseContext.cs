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

        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        

        
        //chỗ này truyền các table
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; } 
        public virtual DbSet<Order> Oders { get; set; } 
        public virtual DbSet<OrderDetail> OderDetails { get; set; } 
        public virtual DbSet<Producer> Producers { get; set; } 
        public virtual DbSet<Product> Products { get; set; } 
        public virtual DbSet<ImportHistory> ImportHistories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigguration()); 
            modelBuilder.ApplyConfiguration(new OderConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProducerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ImportHistoryConfiguration());

            //modelBuilder.Seed(); //gọi cái này để seeding data
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-JNDR021\\SQLEXPRESS;Initial Catalog=databaseDuAn1;Persist Security Info=True; User ID =manh2806; Password =123");

            }
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        //lưu ý chỉ cần thay tên  ở Data Source= tên servername ở máy tính của bạn và phần catalog là tên đb bạn muốn đặt
        //        optionsBuilder.UseSqlServer(@"Server=DESKTOP-JNDR021\\SQLEXPRESS;Database=databaseDuAn1;Trusted_Connection=True;");

        //    }
        //}
    }
}
