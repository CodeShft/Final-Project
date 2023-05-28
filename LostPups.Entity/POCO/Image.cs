using LostPups.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Entity.POCO
{
    public class Image:BaseEntity
    {
        public int PostID { get; set; }
        public string? ImageURL  { get; set; }
        public ICollection<Pups>? Pups  { get; set; }

    }
} 

