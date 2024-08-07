using Bayanihand.DataModel;
using Bayanihand.Repository;

namespace Bayanihand.App.Models.Repositories
{
    public class AdminRepo : GenericRepository<InquiryINV>, IAdminRepo
    {
        public AdminRepo(AppDbContext dbc) : base(dbc)
        {
        }
    }

}