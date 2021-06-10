using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceAutoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RuteController : ControllerBase
    {
        public Ruta ruta;
        public RuteController(Ruta ruta)
        {
            this.ruta = ruta;
        }

        
    }

}
