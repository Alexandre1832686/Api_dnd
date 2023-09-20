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
        public Campagne Campagne { get; set; }


        public Race GetRaceByName(int id)
        {
            throw new NotImplementedException();
        }

        public List<Race> GetAllRace()
        {
            throw new NotImplementedException();
        }

        public Race GetRandomRace()
        {
            throw new NotImplementedException();
        }

        public void PostRace(string nom, int pv, int dex, int force, int intel, int wisdom, int consti)
        {
            throw new NotImplementedException();
        }

        public void PutRace(string nom, int pv, int dex, int force, int intel, int wisdom, int consti)
        {
            throw new NotImplementedException();
        }

        public void DeleteRace(string nom)
        {
            throw new NotImplementedException();
        }
    }
}
