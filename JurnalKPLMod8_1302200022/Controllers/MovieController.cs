using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;



namespace JurnalKPLMod8_1302200022.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class MovieController : ControllerBase
    {
        private string[] SemuaMovie = new[]
        {
            "The Shawshank Redemtion", "The Godfather", "The Dark Knight"
        };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return SemuaMovie;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return SemuaMovie[id];
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpGet("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpGet("{id}")]
        public void Delete(int id)
        {
        }
    }

}
