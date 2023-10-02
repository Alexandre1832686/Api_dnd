using Api_DnD.Data;
using Api_DnD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api_DnD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly DNDContext _context;

        public RaceController(DNDContext context)
        {
            _context = context;
        }

        // GET: api/<RaceController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Race>>> GetRace()
        {
            return await _context.Races.ToListAsync();
        }

        // GET api/<RaceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RaceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RaceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RaceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
