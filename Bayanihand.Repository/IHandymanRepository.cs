using Bayanihand.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayanihand.Repository
{
    public interface IHandymanRepository : IGenericRepository<HandymanINV>
    {
        //Task<HandymanINV?> GetProfileByUserIdAsync(string ID);
    }
}
