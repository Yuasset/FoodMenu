using DAL.Models.Abstracts;

namespace DAL.Models.Concretes
{
    public class MenuItem : Base
    {
        public int MenuID { get; set; }
        public Menu Menu { get; set; }
        public int FoodID { get; set; }
        public Food Food { get; set; }
    }
}
