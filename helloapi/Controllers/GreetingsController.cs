using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using helloapi.Models;
using helloapi.Services;

namespace helloapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        private readonly IGreeterService _service;
        public GreetingsController(IGreeterService service)
        {
            _service = service;
        }

        // GET api/greetings
        [HttpGet]
        public ActionResult<Greeting> Get()
        {
            return Ok(_service.GetGreeting());
        }

        // GET api/greetings/5
        [HttpGet("{name}")]
        public ActionResult<Greeting> Get(string name)
        {
            return Ok(_service.GetGreeting(name));
        }
    }
}
