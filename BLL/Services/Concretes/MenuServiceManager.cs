using BLL.Services.Abstracts;
using DAL.Models.Concretes;
using DAL.Repository.Abstracts;

namespace BLL.Services.Concretes
{
    public class MenuServiceManager : ServiceManager<Menu>, IMenuServiceManager
    {
        public MenuServiceManager(IRepository<Menu> repository): base(repository)
        {
            
        }
    }
}
