using LostPups.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Entity.POCO
{

    public class Pups : BaseEntity
    {

        public int Publisher { get; set; }
        public string? PostName { get; set; }
        public string? PostDesc { get; set; }
        public string? Location { get; set; }
        public int Category { get; set; }
        public virtual Image? Image { get; set; }
        public string? PupsName { get; set; } 
        public string? AdStatus { get; set; }
        public string? AdUrgency { get; set; }
        public string? Breed { get; set; }
        public string? PhysicalCharacteristics { get; set; }
        public string? LeashFeatures { get; set; }
        public virtual ICollection<PupsCategory> ?PupsCategories { get; set; }
       

    }
}
