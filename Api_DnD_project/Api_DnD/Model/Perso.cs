using System.Data;

namespace Api_DnD.Model
{
    public class Perso
    {
        public string IrlJoueur { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int inspiration { get; set; }
        public Armure armure { get; set; }
        public Arme arme1 { get; set; }
        public Arme arme2 { get; set; }
        public Arme arme3 { get; set; }
        public Classes classes { get; set; }
        public Race race { get; set; }
        public List<Skill> skills { get; set; }
        public string personalitetrait { get; set; }
        public string ideal { get; set; }
        public string bonds { get; set; }
        public string flaws { get; set; }
        public int niv { get; set; }
        public int id { get; set; }
        public Campagne Campagne { get; set; }



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

        public static Perso PersoToPerso(Perso x)
        {
            return new Perso
            {
                Nom = x.Nom,
                Description = x.Description,
                inspiration = x.inspiration,
                armure = x.armure,
                arme1 = x.arme1,
                arme2 = x.arme2,
                arme3 = x.arme3,
                classes = x.classes,
                race = x.race,
                skills = x.skills,
                personalitetrait = x.personalitetrait,
                ideal = x.ideal,
                bonds = x.bonds,
                flaws = x.flaws, 
                niv = x.niv,
                id = x.id
            };
        }
        
    }
}
