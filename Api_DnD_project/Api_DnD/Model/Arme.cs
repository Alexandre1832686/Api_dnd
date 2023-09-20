namespace Api_DnD.Model
{
    public class Arme
    {
        public int BonusJet { get; set; }

        public int BonusForce { get; set; }

        public string Nom { get; set; }

        public Enchantement Enchantement { get; set; }
        public Campagne Campagne { get; set; }


        public int id { get; set; }

       public static Arme ArmeToArme(Arme a)
       {
            return new Arme
            {
                BonusJet = a.BonusJet,
                BonusForce = a.BonusForce,
                Nom = a.Nom,
                Enchantement = a.Enchantement,
                id = a.id
            };
       }
    }
}
