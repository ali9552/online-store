﻿using AutoMapper;
using Domain.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Profiles
{
    public class BasketProfile:Profile
    {
        public BasketProfile() {
            CreateMap<CustomerBasket, BasketDto>().ReverseMap();
            CreateMap<BasketItems, BasketItemsDto>().ReverseMap();
        }
    }
}
