using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aec_gama_api.Apresentacao;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aec_gama_api.ModelViews
{
    [ApiController]
    
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public HomeView Get()
        {
            return new HomeView();
        }
        
    }
}