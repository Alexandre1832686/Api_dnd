using Api_DnD.Data;
using Api_DnD.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_DnD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmeController : Controller
    {

        private readonly DNDContext _context;

        public ArmeController(DNDContext context)
        {
            _context = context;
        }

        [HttpGet("/AllArmes")]
        public async Task<ActionResult<IEnumerable<Arme>>> GetAllArmes()
        {
            return await _context.Armes.Include(x => x.Enchantement).Select(x => Arme.ArmeToArme(x)).ToListAsync();
        }

        [HttpGet("/BaseArme/{id}")]
        public async Task<ActionResult<ArmeDTO>> GetBaseInfoArme(int id)
        {
            var arme = await _context.Armes.FindAsync(id);

            if(arme == null)
            {
                return NotFound();
            }

            return ArmeDTO.ArmeToDTO(arme);
        }

        [HttpPost("/CreateArme/{bonusJet}/{bonusForce}/{nom}/{enchantementId}")]
        public async void CreateArme(int bonusJet, int bonusForce, string nom, int enchantementId)
        {
            Enchantement enchantement = await _context.Enchantements.Where(e => e.Id.Equals(enchantementId)).Select(e => Enchantement.EnchantementToEnchantement(e)).FirstOrDefaultAsync();

            await _context.Armes.AddAsync(new Arme { BonusJet = bonusJet, BonusForce = bonusForce, Nom = nom, Enchantement = enchantement });
        }

        [HttpPut("/EditArme/{Id}/{bonusJet}/{bonusForce}/{nom}/{enchantementId}")]
        public async void EditArme(int Id, int bonusJet, int bonusForce, string nom, int enchantementId)
        {
            Enchantement enchantement = await _context.Enchantements.Where(e => e.Id.Equals(enchantementId)).Select(e => Enchantement.EnchantementToEnchantement(e)).FirstOrDefaultAsync();

            await _context.Armes.Where(a => a.id == Id).ExecuteUpdateAsync(setters => setters
            .SetProperty(a => a.BonusJet, bonusJet)
            .SetProperty(a => a.BonusForce, bonusForce)
            .SetProperty(a => a.Nom, nom)
            .SetProperty(a => a.Enchantement, enchantement));
        }

        // POST: ArmeController/Delete/5
        // Si une entrée est trouvée et supprimée, la valeur true est retournée, sinon c'est la valeur false
        [HttpDelete("/DeleteArme/{id}")]
        public async Task<bool> Delete(int id)
        {
            if (await _context.Armes.Where(a => a.id.Equals(id)).ExecuteDeleteAsync() == 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
