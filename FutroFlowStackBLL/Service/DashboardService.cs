using AutoMapper;
using FutroFlowStackBLL.ServiceInterface;
using FutroFlowStackDAL.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutroFlowStackBLL.Service
{
    public class DashboardService : IDashboardService
    {
        private readonly IMapper _mapper;
        private readonly IDashboardRepository _Dashboardrepository;

        public DashboardService (IMapper mapper, IDashboardRepository repository)
        {
            _mapper = mapper;
            _Dashboardrepository = repository;
        }
    }
}
