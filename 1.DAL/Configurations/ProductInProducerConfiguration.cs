using _1.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class ProductInProducerConfiguration : IEntityTypeConfiguration<ProductInProducerConfiguration>
    {
        public void Configure(EntityTypeBuilder<ProductInProducerConfiguration> builder)
        {
        //    builder.HasKey(t => new { t.ProductId, t.ProducerID });

        //    builder.ToTable("ProductInProducers");

        //    builder.HasOne(t => t.Product).WithMany(pp => pp.ProductInProducers).HasForeignKey(pc => pc.ProductId);
        //    //tạo khóa phụ liên kết 2 bảng PRODUCT vs PRODUCER = ProductID
        //    builder.HasOne(t=>t.Producer).WithMany(pp=>pp.ProductInProducers).HasForeignKey(pc => pc.ProducerID);
            
        }
    }
}
