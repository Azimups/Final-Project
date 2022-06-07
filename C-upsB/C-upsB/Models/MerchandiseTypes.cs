namespace C_upsB.Models
{
    public class MerchandiseTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int MerchandiseId { get; set; }
        public Merchandise Merchandise { get; set; }
    }
}