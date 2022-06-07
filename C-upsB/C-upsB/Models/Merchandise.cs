using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace C_upsB.Models
{
    public class Merchandise
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }

        public List<Thumbs> Thumbs { get; set; }

        public List<MerchandiseTypes> MerchandiseTypesList { get; set; }
        [NotMapped] public IFormFile Photo { get; set; }
        public Boolean IsDeleted { get; set; }
    }
}