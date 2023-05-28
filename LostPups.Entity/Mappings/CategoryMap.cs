using LostPups.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Entity.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {


        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(k => k.CategoryName).HasColumnName("Name").HasColumnType("nvarchar(150)").IsRequired();
            builder.HasIndex(k => k.CategoryName).IsUnique();
        }
    }
}

