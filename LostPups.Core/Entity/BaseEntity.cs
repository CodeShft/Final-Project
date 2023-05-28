using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Core.Entity
{

    public interface IBaseEntity
    {
        
    }
    public class BaseEntity:IBaseEntity
    {
       

        public BaseEntity() 
        {
            Active      = true;
            Deleted     = false;
            CreatedTime = DateTime.Now;
            UpdatedTime = DateTime.Now;
        }


        public int Id { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set;}

    }
}
