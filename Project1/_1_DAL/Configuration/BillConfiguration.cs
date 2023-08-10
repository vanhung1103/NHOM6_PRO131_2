using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _1_DAL.Configuration
{
    public class BillConfiguration: IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> buider)
        {
            buider.ToTable("Bill");

            buider.HasKey(x => x.Id);
            buider.Property(p => p.User_Id).IsRequired();
            buider.Property(p => p.Voucher_Id).IsRequired();
            buider.Property(p => p.MaHD).HasColumnName("MaHD").HasColumnType("nvarchar(100)").IsRequired();

            buider.Property(p => p.Discount).HasColumnName("Discount").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.Create_Date).HasColumnName("Create_Date").HasColumnType("datetime").IsRequired();
            buider.Property(p => p.Description).HasColumnName("Des").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.ProductName).HasColumnName("product name").HasColumnType("nvarchar(100)").IsRequired();
            buider.Property(p => p.Total).HasColumnName("Total").HasColumnType("float").IsRequired();

            buider.HasOne(p => p.User).WithMany().HasForeignKey(p => p.User_Id);
            buider.HasOne(p => p.Voucher).WithMany().HasForeignKey(p => p.Voucher_Id);
        }
    
    }
}
