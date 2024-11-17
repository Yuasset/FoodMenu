
using DAL.Models.Concretes;

namespace DAL.Data
{
    internal class FoodData
    {
        public static List<Food> Data()
        {
            return new List<Food>{
                new Food { ID = 1, Name = "Rosto", Description = "Kımyadan yapılan fırında köfte", Calorie = 500, CategoryID = 1 },
                new Food { ID = 2, Name = "Mevsim Salata", Description = "Mevsim yeşillikleri ile hazırlanan salata", Calorie = 200, CategoryID = 3 },
                new Food { ID = 3, Name = "Ezogelin", Description = "Çorba çeşidi", Calorie = 60, CategoryID = 2 },
                new Food { ID = 4, Name = "Su", Description = "Her yemek yanında verilir", Calorie = 10, CategoryID = 5 },
                new Food { ID = 5, Name = "Meyva suyu", Description = "Meyve aromalı su", Calorie = 40, CategoryID = 5 },
                new Food { ID = 6, Name = "Karnıyarık", Description = "Patlıcan arasında kıyma", Calorie = 200, CategoryID = 1 },
                new Food { ID = 7, Name = "Şekerpare", Description = "Unlu talı çeşidi", Calorie = 200, CategoryID = 6 },
                new Food { ID = 8, Name = "Yayla Çorbası", Description = "Yoğurtla yapılan çorba çeşidi", Calorie = 160, CategoryID = 2 }
            };
        }
    }
}