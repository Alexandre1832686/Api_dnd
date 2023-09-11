using System.Data;

namespace Api_DnD.Model
{
    public class Perso
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public int inspiration { get; set; }
        public Armure armure { get; set; }
        public Arme arme { get; set; }
        public Classes classes { get; set; }
        public Race race { get; set; }
        public List<Skill> skills { get; set; }
        public string personalitetrait { get; set; }
        public string ideal { get; set; }
        public string bonds { get; set; }
        public string flaws { get; set; }
        public int niv { get; set; }
        public int id { get; set; }

        public int[] GetStats()
        {
            throw new NotImplementedException();
        }
        public List<int> GetSkills()
        {
            throw new NotImplementedException();
        }
        public int GetAC()
        {
            throw new NotImplementedException();
        }
        public int GetSpellDC()
        {
            throw new NotImplementedException();
        }
        public int GetProficiencyBonus()
        {
            throw new NotImplementedException();
        }
        
    }
}
