namespace Api_DnD.Model
{
    public class Campagne
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public ICollection<PNJ> PNJs { get; set; }
        public ICollection<Extension> Extensions { get; set; }
        public ICollection<Quete> Quetes { get; set; }

    }
}
