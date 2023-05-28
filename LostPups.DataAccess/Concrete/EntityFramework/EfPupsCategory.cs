using LostPups.DataAccess.Abstract;
using LostPups.Entity.Context;
using LostPups.Entity.POCO;

namespace LostPups.DataAccess.Concrete.EntityFramework
{
    public class EfPupsCategory : EfRepository<PupsCategory, LostPupsDbContext>, IPupsCategoryDAL
    {
        private readonly LostPupsDbContext context;
        public EfPupsCategory(LostPupsDbContext dbContext) : base(dbContext)
        {
            context = dbContext;
        }
    }
}