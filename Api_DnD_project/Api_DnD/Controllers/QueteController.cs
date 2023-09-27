using Api_DnD.Data;
using Api_DnD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_DnD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueteController : Controller
    {
        private readonly DNDContext _context;

        public QueteController(DNDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quete>>> GetQuete()
        {
            return await _context.Quetes.Include(x => )
        }
    }
}
