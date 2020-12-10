using AutoMapper;
using DTO;
using MoviesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.App.Profiles
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketDTO, BasketDetailsModel>();
        }
    }
}