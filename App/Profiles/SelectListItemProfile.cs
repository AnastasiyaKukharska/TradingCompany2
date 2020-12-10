using AutoMapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.App.Profiles
{
    public class SelectListItemProfile : Profile
    {
        public SelectListItemProfile()
        {
            CreateMap<BooksDTO, SelectListItem>()
                .ForMember(dest => dest.Value, src => src.MapFrom(b => b.BookID))
                .ForMember(dest => dest.Text, src => src.MapFrom(b => b.Title));

        }
    }
}