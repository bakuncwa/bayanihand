using Bayanihand.DataModel;
using Bayanihand.Repository;

namespace Bayanihand.App.Models.Repositories
{
    public class PaymentRepo : GenericRepository<PaymentProofINV>, IPaymentRepo
    {
        public PaymentRepo(AppDbContext dbc) : base(dbc) { }
    }
}
