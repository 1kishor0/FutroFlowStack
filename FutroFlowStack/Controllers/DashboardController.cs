using FutroFlowStackBLL.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutroFlowStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _Dashboardservice;

        public DashboardController(IDashboardService service)
        {

            _Dashboardservice = service;
        }
    }
}
