using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PunditWebApp.Controllers
{
    // base class for all API controllers

    // sets the route to be in the fourm "api/[controllerName]"
    [Route("api/[controller]")]
    [ApiController]
    public class APIBaseController : ControllerBase
    {

    }
}
