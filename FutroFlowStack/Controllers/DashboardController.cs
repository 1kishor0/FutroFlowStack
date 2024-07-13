using FutroFlowStackBLL.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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


        [HttpPost]
        [Route("GetHomePage")]
        public async Task<IActionResult> GetHomePage(int token)
        {

            try
            {
                var Token = await _Dashboardservice.GetHomePage(token);
                return Ok(Token);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
