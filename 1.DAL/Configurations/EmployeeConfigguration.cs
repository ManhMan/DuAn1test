using _1.DAL.Entities;
using _1.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class EmployeeConfigguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(x => x.ID);
            
            builder.Property(x => x.ID).UseIdentityColumn();

            
            builder.Property(x => x.UserName).IsRequired();

            builder.Property(x => x.Password).IsRequired();

            builder.Property(x => x.FullName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.Sex);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.Dob).IsRequired();

            builder.Property(x => x.Phone).IsRequired().HasMaxLength(10);
        }
    }
}
