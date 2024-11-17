using DAL.Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    internal class CategoryData
    {
        public static List<Category> Data()
        {
            return new List<Category>
            {
                new Category { ID = 1, Name = "Ana Yemek" },
                new Category { ID = 2, Name = "Çorba" },
                new Category { ID = 3, Name = "Ara Yemek" },
                new Category { ID = 4, Name = "Meyve" },
                new Category { ID = 5, Name = "İçecek" },
                new Category { ID = 6, Name = "Tatlı" },
            };
        }
    }
}
