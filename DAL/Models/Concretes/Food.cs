using DAL.Models.Abstracts;

namespace DAL.Models.Concretes
{
    public class Food : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Calorie { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }
}
