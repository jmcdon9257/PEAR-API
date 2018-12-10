using AutoMapper;
using PEARApi.Models;
using PEARApi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi
{
    public class DomainProfile: Profile
    {
        public DomainProfile()
        {
            CreateMap<CustomerViewModel, Customer>().ReverseMap();
            CreateMap<DeviceViewModel, Device>().ReverseMap();
            CreateMap<RepairViewModel, Repair>().ReverseMap();
        }
      
    }
}
