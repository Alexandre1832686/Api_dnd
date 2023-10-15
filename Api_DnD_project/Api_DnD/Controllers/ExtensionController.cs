using Api_DnD.Data;
using Api_DnD.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_DnD.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class ExtensionController : Controller
    {
        private readonly DNDContext _context;

        public ExtensionController(DNDContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Extension>>> GetExtensions()
        {
            return await _context.Extensions
               .Include(e => e.Monstres.Select(m => m.Actions))
               .Include(e => e.Armes.Select(a => a.Enchantement))
               .Include(e => e.Armures.Select(a => a.Enchant))
               .Include(e => e.Enchantements)
               .Include(e => e.Classes)
               .Include(e => e.Races)
               .Include(e => e.Campagnes.Select(c => c.PNJs))
               .Include(e => e.Campagnes.Select(c => c.Quetes))
               .ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Extension>>> GetExtension(int idExtension)
        {
            return await _context.Extensions
               .Include(e => e.Monstres.Select(m => m.Actions))
               .Include(e => e.Armes.Select(a => a.Enchantement))
               .Include(e => e.Armures.Select(a => a.Enchant))
               .Include(e => e.Enchantements)
               .Include(e => e.Classes)
               .Include(e => e.Races)
               .Include(e => e.Campagnes.Select(c => c.PNJs))
               .Include(e => e.Campagnes.Select(c => c.Quetes))
               .Where(e => e.Id ==idExtension)
               .ToListAsync();
        }
    }  
}
