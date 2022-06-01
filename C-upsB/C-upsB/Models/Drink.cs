namespace C_upsB.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public double price { get; set; }
        public double Description { get; set; }
        public string TypeFirst { get; set; }
        public string TypeSecond { get; set; }
        public string TypeThird { get; set; }
        public string InformationHeader { get; set; }
        
        
        public string SizeL { get; set; }
        public string SizeM { get; set; }
        public string SizeS { get; set; }
        
        
        public string NutritionalCalories { get; set; }
        public string NutritionalTotalFat { get; set; }
        public string NutritionalCholesterol { get; set; }
        public string NutritionalSodium { get; set; }
        public string NutritionalTotalCarbs { get; set; }
        public string NutritionalTotalFiber { get; set; }
        public string NutritionalTotalSugar { get; set; }
        public string NutritionalTotalProtein { get; set; }
        
        
        public string SizeLCalories { get; set; }
        public string SizeLTotalFat { get; set; }
        public string SizeLCholesterol { get; set; }
        public string SizeLSodium { get; set; }
        public string SizeLTotalCarbs { get; set; }
        public string SizeLTotalFiber { get; set; }
        public string SizeLTotalSugar { get; set; }
        public string SizeLTotalProtein { get; set; }
        
        public string SizeMCalories { get; set; }
        public string SizeMTotalFat { get; set; }
        public string SizeMCholesterol { get; set; }
        public string SizeMSodium { get; set; }
        public string SizeMTotalCarbs { get; set; }
        public string SizeMTotalFiber { get; set; }
        public string SizeMTotalSugar { get; set; }
        public string SizeMTotalProtein { get; set; }
        
        public string SizeSCalories { get; set; }
        public string SizeSTotalFat { get; set; }
        public string SizeSCholesterol { get; set; }
        public string SizeSSodium { get; set; }
        public string SizeSTotalCarbs { get; set; }
        public string SizeSTotalFiber { get; set; }
        public string SizeSTotalSugar { get; set; }
        public string SizeSTotalProtein { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        

    }
}