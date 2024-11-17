using BLL.Services.Abstracts;
using DAL.Models.Concretes;
using DAL.Repository.Abstracts;

namespace BLL.Services.Concretes
{
    public class FoodServiceManager : ServiceManager<Food>, IFoodServiceManager
    {
        public FoodServiceManager(IRepository<Food> repository) : base(repository)
        {
        }
    }
}
