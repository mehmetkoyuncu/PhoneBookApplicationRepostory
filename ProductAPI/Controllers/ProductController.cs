using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new List<string> { "Kalem", "Kitap", "Silgi", "Defter" });
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new List<string> { "Kalem", "Kitap", "Silgi", "Defter" }[id]);
        }

        [HttpDelete("[action]")]
        public IActionResult Delete()
        {
            return Ok("Silme işlemi başarılı.");
        }
    }
}
