using Bayanihand.DataModel;
using Bayanihand.Repository;

namespace Bayanihand.App.Models.Repository
{
    public class ForumRepository : GenericRepository<ForumINV>, IForumRepository
    {
        public ForumRepository(AppDbContext dbc) : base(dbc) { }
    }
}
