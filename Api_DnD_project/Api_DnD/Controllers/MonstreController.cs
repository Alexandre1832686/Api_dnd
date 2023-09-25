using Api_DnD.Data;
using Api_DnD.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_DnD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonstreController : Controller
    {
        private readonly DNDContext _context;

        public MonstreController(DNDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Monstre>>> GetMonstre()
        {
            return await _context.Monstres
                .Include(x => x.Race)
                .Include(x => x.ListAction)
                .Include(x => x.Campagne).ToListAsync();
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<Monstre>> GetMonstre(int id)
        {
            return await _context.Monstres.FindAsync(id);
        }

        // Besoin de savoir comment on va arranger la base de données pour les Monstres avant de continuer
        /*
        [HttpPut("/EditMonstre")] 
        public async Task<ActionResult<Monstre>> EditMonstre(int )
        */
    }
}
