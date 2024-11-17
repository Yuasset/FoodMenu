using DAL.Models.Concretes;

namespace DAL.Data
{
    internal class MenuData
    {
        public static List<Menu> Data()
        {
            return new List<Menu>
            {
                new Menu { ID = 1, Name = "Perşembe Menüsü", Description = "Rahat tüketilebilir", Date = new DateTime(2024, 11, 14) },
                new Menu { ID = 2, Name = "Cuma Menüsü", Description = "Lezzetli ve doyurucu", Date = new DateTime(2024, 11, 15) }
            };
        }
    }
}
