using DAL.Models.Abstracts;

namespace DAL.Models.Concretes
{
    public class Menu : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }
}
