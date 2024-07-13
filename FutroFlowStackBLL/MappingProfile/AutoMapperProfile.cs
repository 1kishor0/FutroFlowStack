using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FutroFlowStackBLL.DTO;
using FutroFlowStackDAL.Entity;
namespace FutroFlowStackBLL.MappingProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Dashboard, Dashboard_DTO>().ReverseMap();
        }
    }
}
