using BLL.Services.Abstracts;
using DAL.Models.Concretes;
using DAL.Repository.Abstracts;

namespace BLL.Services.Concretes
{
    public class CategoryServiceManager : ServiceManager<Category>, ICategoryServiceManager
    {
        public CategoryServiceManager(IRepository<Category> repository) : base(repository)
        {
        }
    }
}
