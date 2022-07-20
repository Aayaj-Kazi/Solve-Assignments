using Microsoft.AspNetCore.Mvc;
using Mini_Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecuritiesController : Controller
    {
       
        private IServiceLayer _serviceLayer;
        public SecuritiesController(IServiceLayer serviceLayer)
        {
            _serviceLayer = serviceLayer;
        }

        [HttpGet]
        [Route("GetAllSecurities")]
        public IActionResult GetAllSecurity()
        {
            return Ok(_serviceLayer.GetAllSecurities());
        }

        [HttpGet]
        [Route("GetQuotesBySecurityId/{id}")]
        public IActionResult GetQouteBySecurityId(int id)
        {
            return Ok(_serviceLayer.GetQuotesBySecurity(id));
        }
    }
}
