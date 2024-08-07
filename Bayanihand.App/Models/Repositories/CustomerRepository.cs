using Bayanihand.DataModel;
using Bayanihand.Repository;

namespace Bayanihand.App.Models.Repository
{
    public class CustomerRepository : GenericRepository<CustomerINV>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext _dbcontext) : base(_dbcontext)
        {
        }
    }
}
