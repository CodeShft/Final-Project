using LostPups.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Entity.POCO
{
    
    public class Category: BaseEntity
    {
        
        public string? CategoryName { get; set; }

        public virtual ICollection<PupsCategory>? PupsCategory { get; set; }

    }
}
