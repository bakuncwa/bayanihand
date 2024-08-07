using Bayanihand.DataModel;
using Bayanihand.Repository;

namespace Bayanihand.App.Models.Repositories
{
    public class SchedRepo : GenericRepository<ScheduleINV>, ISchedRepo
    {
        public SchedRepo(AppDbContext dbc) : base(dbc) { }
    }
}
