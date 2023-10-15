namespace Api_DnD.Model
{
    public class Extension
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Arme> Armes { get; set; }
        public ICollection<Armure> Armures { get; set; }
        public ICollection<Enchantement> Enchantements { get; set; }
        public ICollection<Monstre> Monstres { get; set; }
        public ICollection<Classes> Classes { get; set; }
        public ICollection<Race> Races { get; set; }
        public ICollection<Campagne> Campagnes { get;set;}
    }
}
