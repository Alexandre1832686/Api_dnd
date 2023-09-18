namespace Api_DnD.Model
{
    public class PNJ
    {
        public int[] Physique { get; set; }

        public string Description;

        public string Name;
        
        public string[] Quête { get; set; }

        public PNJ(int[] physique, string description, string name, string[] quête)
        {
            Physique = physique;
            Description = description;
            Name = name;
            Quête = quête;
        }
    }
}
