using System;
using System.Collections.Generic;

namespace C_upsB.Models
{
    public class Merchandise
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Description { get; set; }
        public double Information { get; set; }
        
        public List<MerchandiseTypes> MerchandiseTypesList { get; set; }
    }
}