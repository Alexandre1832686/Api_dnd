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

        public Enchantement Enchant { get; set; }
        public Campagne Campagne { get; set; }

        public int Id { get; set; }
    }
}
