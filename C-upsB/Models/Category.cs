using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace C_upsB.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string HeaderText { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string BtnText { get; set; }
        public string FeaturedHeader { get; set; }
        public string FeaturedDrinkFirst { get; set; }
        public string FeaturedDrinkSecond { get; set; }
        public string FeaturedDrinkThird { get; set; }
        public string MenuHeader { get; set; }

        public ICollection<Drink> Drinks { get; set; }
        
        [NotMapped] public IFormFile Photo { get; set; }
        public Boolean IsDeleted { get; set; }
    }
}