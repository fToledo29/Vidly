using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyII.DTOs;
using VidlyII.Models;

namespace VidlyII.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}