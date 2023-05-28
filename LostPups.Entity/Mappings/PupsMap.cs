using LostPups.Entity.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Entity.Mappings
{
    public class PupsMap: IEntityTypeConfiguration<Pups>
    {
        
     
     public void Configure(EntityTypeBuilder<Pups> builder)
        {
            builder.Property(x => x.PupsName).HasColumnName("Name").HasColumnType("nvarchar(70)").IsRequired();  
        }
    }
} 
