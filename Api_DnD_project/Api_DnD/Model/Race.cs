namespace Api_DnD.Model
{
    public class Race
    {
        public string Nom { get; set; }
        public int BonusPV { get; set; }
        public int BonusDex { get; set; }
        public int BonusForce { get; set; }
        public int BonusIntel { get; set; }
        public int BonusWisdom { get; set; }
        public int BonusConsti { get; set; }
        public int Id { get; set; }
        public ICollection<Campagne> Campagne { get; set; }
    }
}
