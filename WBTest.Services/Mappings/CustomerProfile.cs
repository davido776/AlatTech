using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBTest.Models;
using WBTest.Services.Entities;

namespace WBTest.Services.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();

            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
