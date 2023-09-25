namespace Api_DnD.Model
{
    public class PersoDTO
    {
        public string Nom { get; set; }
        public int niv { get; set; }
        public int id { get; set; }
        

        public PersoDTO() { }

        public static PersoDTO PersoToDTO(Perso p)
        {
            return new PersoDTO { Nom = p.Nom, id = p.id, niv = p.niv };
        }
    }
}