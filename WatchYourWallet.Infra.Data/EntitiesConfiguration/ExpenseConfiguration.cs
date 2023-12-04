using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchYourWallet.Domain.Entities;

namespace WatchYourWallet.Infra.Data.EntitiesConfiguration
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Value).HasPrecision(10,2).IsRequired();
            builder.Property(e => e.InitialDate).IsRequired();
            builder.Property(e => e.LastDate).IsRequired();

            builder.HasOne(u => u.Users).WithMany(e => e.Expense)
                .HasForeignKey(e => e.UserId);
        }
    }
}
