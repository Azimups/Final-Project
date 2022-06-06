using System.Collections.Generic;
using C_upsB.Models;

namespace C_upsB.ViewModels
{
    public class HomeViewModel
    {
        public Stylish Stylish { get; set; }
        public AboutImages AboutImages { get; set; }
        public AboutTexts AboutTexts { get; set; }
        public AboutDetail AboutDetails { get; set; }

        public List<Category> Categories { get; set; }
        
        public List<Drink> Drinks { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<BlogRelated> BlogRelateds { get; set; }

        public List<Merchandise> Merchandises { get; set; }
    }
}