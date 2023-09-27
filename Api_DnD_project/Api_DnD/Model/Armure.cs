using System.ComponentModel.DataAnnotations.Schema;

namespace Api_DnD.Model
{
    public class Armure
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Ac { get; set; }

        public bool DexBonus { get; set; }

        public int MaxDexMod { get; set; }

        public bool StealthDisadvantage { get; set; }

        public int EnchantementId { get; set; }

        [ForeignKey("EnchantementId")]
        public Enchantement Enchantement { get; set; }
        public ICollection<Campagne> Campagne { get; set; }
        public int Id { get; set; }

        public Armure(string name, string type, int ac, bool dexBonus, int maxDexMod, bool stealthDisadvantage, int enchantementId, int id)
        {
            Name = name;
            Type = type;
            Ac = ac;
            DexBonus = dexBonus;
            MaxDexMod = maxDexMod;
            StealthDisadvantage = stealthDisadvantage;
            EnchantementId = enchantementId;
            Id = id;
        }

        public Armure() { }

        public static Armure ArmureToArmure(Armure a)
        {
            return new Armure()
            {
                Name = a.Name,
                Type = a.Type,
                Ac = a.Ac,
                DexBonus = a.DexBonus,
                MaxDexMod = a.MaxDexMod,
                StealthDisadvantage = a.StealthDisadvantage,
                EnchantementId = a.EnchantementId,
                Enchantement = a.Enchantement
            };
        }
    }
}
