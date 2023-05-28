using LostPups.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Entity.POCO
{
    public class PupsCategory:IBaseEntity
    { 
        public int PostID { get; set; }
        public int PupsCategoryID { get; set; }
        public string? GenusName { get; set; }
        public string? PupsDescription { get; }
        public string? PupsColour { get; set; }
        public int? DisappearanceDate { get; set; }
        public int? PupsAge { get; set; }


    } 
    
}
