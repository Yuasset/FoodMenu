using DAL.Models.Abstracts;

namespace BLL.Services.Abstracts
{
    public interface IServiceManager<T> where T : Base
    {
        IEnumerable<T> GetAll();
        T GetByID(int key);
        Task CreateAsync(T model);
        Task UpdateAsync(T model);
        void DeleteAsync(T model);
    }
}
