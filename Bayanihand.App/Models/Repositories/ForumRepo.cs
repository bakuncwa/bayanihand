using Bayanihand.DataModel;
using Bayanihand.Repository;

namespace Bayanihand.App.Models.Repositories
{
    public class ForumRepo : GenericRepository<ForumINV>, IForumRepo
    {
        public ForumRepo(AppDbContext dbc) : base(dbc) { }
    }
}
