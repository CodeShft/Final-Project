using LostPups.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.Core.BLL
{
    public interface IGenericService<T>where T: class,IBaseEntity,new()
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> Get();
        T Get(int id);



    } 
}
