using AutoMapper;
using Bayanihand.App.Models;
using Bayanihand.DataModel;

namespace Bayanihand.App.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<ForumINV, ForumVM>().ReverseMap();
            CreateMap<HandymanINV, HandymanProfileVM>().ReverseMap();
            CreateMap<CustomerINV, CustomerProfileVM>().ReverseMap();
            CreateMap<ScheduleINV, ScheduleVM>().ReverseMap();
            CreateMap<PaymentProofINV, PaymentVM>().ReverseMap();
        }
    }
}
