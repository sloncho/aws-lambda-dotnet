using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    public class MultiValueQueryStringController : Controller
    {

        [HttpGet]
        public string Get([FromQuery(Name = "name")] string name, [FromQuery(Name = "color")] IEnumerable<string> colors)
        {
            return $"{name} paints with {string.Join(", ", colors)}";
        }
    }
}
