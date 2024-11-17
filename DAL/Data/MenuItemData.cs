
using DAL.Models.Concretes;

namespace DAL.Data
{
    internal class MenuItemData
    {
        public static List<MenuItem> Data()
        {
            return new List<MenuItem>
            {
                new MenuItem { ID = 1, MenuID = 1, FoodID = 6 },
                new MenuItem { ID = 2, MenuID = 1, FoodID = 3 },
                new MenuItem { ID = 3, MenuID = 1, FoodID = 2 },
                new MenuItem { ID = 4, MenuID = 1, FoodID = 4 },
                new MenuItem { ID = 5, MenuID = 2, FoodID = 1 },
                new MenuItem { ID = 6, MenuID = 2, FoodID = 8 },
                new MenuItem { ID = 7, MenuID = 2, FoodID = 4 },
                new MenuItem { ID = 8, MenuID = 2, FoodID = 5 }
            };
        }
    }
}
