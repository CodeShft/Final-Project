using LostPups.DataAccess.Abstract;
using LostPups.Entity.Context;
using LostPups.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPups.DataAccess.Concrete.EntityFramework
{
    public class EfPups:EfRepository<Pups,LostPupsDbContext>, IPupsDAL
    {
        private readonly LostPupsDbContext _context;

        public EfPups(LostPupsDbContext context):base(context) 
        {
            _context = context;
        }
    }
}
