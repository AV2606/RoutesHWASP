using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutesHWASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("{id:min(6)}")]
        public IActionResult GetValue(int id)
        {
            return Ok("Hello from Int GetValue");
        }

        [HttpGet("{str:regex(^((books)(zoom|boom))$)}")]
        public IActionResult GetValue(string str)
        {
            return Ok("Hello from Regex GetValue");
        }


    }
}
