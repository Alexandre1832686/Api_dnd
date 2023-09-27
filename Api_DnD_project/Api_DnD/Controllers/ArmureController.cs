using Api_DnD.Data;
using Api_DnD.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_DnD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArmureController : Controller
    {
        private readonly DNDContext _context;

        public ArmureController(DNDContext context)
        {
            _context = context;
        }

        [HttpGet("/GetAllArmure")]
        public async Task<ActionResult<IEnumerable<Armure>>> GetArmure()
        {
            return await _context.Armures.Include(a => a.Enchantement).Select(a => Armure.ArmureToArmure(a)).ToListAsync();
        }

        [HttpGet("/GetArmureById/{id}")]
        public async Task<ActionResult<Armure>> GetArmureById(int id)
        {
            return await _context.Armures.FindAsync(id);
        }

        //[HttpPost("/EditArmure/{Id}, {Name}, {Type}, {Ac}, {DexBonus}, {MaxDexMod}, {StealthDisadvantage}, {EnchantementId}")]
        //public async Task<ActionResult<Armure>> EditArmure(string name,string type, int ac, int dexBonus,int maxDexBonus, int stealthDisadvantage,int EnchantementId,int id)
        //{
        //    Armure? armure1 = await _context.Armures.FindAsync(id);

        //    Armure armure 2 = new Armure(name,type,ac,dexBonus,maxDexBonus,stealthDisadvantage,EnchantementId,id);

        //}
    }
}
