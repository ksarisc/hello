using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using helloapi.Models;

namespace helloapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        private readonly IGreeter _greeter;
        public GreetingsController(IGreeter greeter)
        {
            _greeter = greeter;
        }

        // GET api/greetings
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/greetings/5
        [HttpGet("{name}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
