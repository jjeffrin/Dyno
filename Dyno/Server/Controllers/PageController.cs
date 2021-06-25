using Dyno.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dyno.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        [HttpGet]
        [Route("/GetPage")]
        public IEnumerable<PageModel> Get()
        {
            return new List<PageModel>() 
            { 
                new PageModel()
                {
                    Name = ""
                }
            };
        }
    }
}
