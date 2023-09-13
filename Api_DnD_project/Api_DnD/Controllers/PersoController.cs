﻿using Api_DnD.Data;
using Api_DnD.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_DnD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersoController : ControllerBase
    {
        

        private readonly DNDContext _context;

        public PersoController(DNDContext context)
        {
            _context = context;
        }

        // GET: PersoController/Create
        [HttpGet("/AllPerso")]
        public async Task<ActionResult<IEnumerable<Perso>>> GetAllPerso()
        {

            return await _context.Persos.Include(x => x.arme).Include(x=>x.arme.Enchantement).Include(x => x.armure).Include(x=>x.armure.Enchant)
                .Select( x => Perso.PersoToPerso(x))
                .ToListAsync();
        }

        // GET: PersoController/Create
        [HttpGet ("/BasePerso")]
        public async Task<ActionResult<PersoDTO>> GetBaseInfo(int id)
        {
            var perso = await _context.Persos.FindAsync(id);

            if(perso == null)
            {
                return NotFound();
            }

            return PersoDTO.PersoToDTO(perso);
        }
    }
}
