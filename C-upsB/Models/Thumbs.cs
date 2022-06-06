namespace C_upsB.Models
{
    public class Thumbs
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public int MerchId { get; set; }
        public Merchandise Merchandise { get; set; }
    }
}