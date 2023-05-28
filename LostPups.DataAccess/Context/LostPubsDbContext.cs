using LostPups.Entity.Mappings;
using LostPups.Entity.POCO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Entity.Context
{
    public class LostPupsDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

            optionBuilder.UseSqlServer("Server=.;Database=LostPupsDb;Trusted_Connection=True;");
            base.OnConfiguring(optionBuilder);

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PupsCategory>().HasKey(x => new { x.PupsCategoryID, x.PostID });
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new PupsMap());


            base.OnModelCreating(builder);
        }
        
        public DbSet<Pups>? Pups { get; set; }
        public DbSet<Category>? Category { get; set; }
        public DbSet<PupsCategory>? PupsCategory { get; set; }
        public DbSet<Image>? Image { get; set; }



    }
}
