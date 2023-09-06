namespace Api_DnD.Model
{
    public class Enchantement
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Modif { get; set; }
        public int Id { get; set; }

        public Enchantement GetEnchantementById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Enchantement> GetAllEnchantement()
        {
            throw new NotImplementedException();
        }

        public Enchantement GetRandomEnchantement()
        {
            throw new NotImplementedException();
        }

        public void PostEnchantement(string nom, string description, string type, int modif)
        {
            throw new NotImplementedException();
        }

        public void PutEnchantement(string nom, string description, string type, int modif)
        {
            throw new NotImplementedException();
        }

        public void DeleteEnchantement(string nom)
        {
            throw new NotImplementedException();
        }
    }
}
