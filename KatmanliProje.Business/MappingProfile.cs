using AutoMapper;
using KatmanliProje.Dto;
using KatmanliProje.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KatmanliProje.Business
{
   public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Categories, CategoriesDTO>();
            CreateMap<CategoriesDTO, Categories>();
        }
    }
}
