﻿using AutoMapper;
using Bayanihand.App.Models;
using Bayanihand.DataModel;

namespace Bayanihand.App.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<ForumINV, ForumVM>().ReverseMap();
        }
    }
}
