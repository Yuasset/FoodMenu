using BLL.Services.Abstracts;
using DAL.Models.Concretes;
using DAL.Repository.Abstracts;

namespace BLL.Services.Concretes
{
    public class MenuItemServiceManager : ServiceManager<MenuItem>, IMenuItemServiceManager
    {
        private readonly IRepository<MenuItem> repository;

        public MenuItemServiceManager(IRepository<MenuItem> repository) : base(repository)
        {
            this.repository = repository;
        }

        public IEnumerable<MenuItem> GetMenuItems(int key)
        {
            return repository.GetAll().Where(x => x.MenuID == key).ToList();
        }
    }
}
