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
    public class EfCategory: EfRepository<Category, LostPupsDbContext>, ICategoryDAL
    {
        private LostPupsDbContext _db;
        public EfCategory(LostPupsDbContext db) : base(db)
        {
            _db = db;
        }
    }
}