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
    public class EfImage : EfRepository<Image, LostPupsDbContext>, IImageDAL
    {
        private readonly LostPupsDbContext _context;
        public EfImage(LostPupsDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
