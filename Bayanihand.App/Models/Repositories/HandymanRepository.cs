using Bayanihand.DataModel;
using Bayanihand.Repository;

namespace Bayanihand.App.Models.Repository
{
    public class HandymanRepository : GenericRepository<HandymanINV>, IHandymanRepository
    {
        public HandymanRepository(AppDbContext _dbcontext) : base(_dbcontext)
        {
        }
    }
}
