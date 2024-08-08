using Bayanihand.DataModel;
using Bayanihand.Repository;
using Microsoft.EntityFrameworkCore;

namespace Bayanihand.App.Models.Repository
{
    public class HandymanRepository : GenericRepository<HandymanINV>, IHandymanRepository
    {
        public HandymanRepository(AppDbContext dbc) : base(dbc)
        {
        }
    }
}
