using DAL.Models.Abstracts;

namespace DAL.Repository.Abstracts
{
    public interface IRepository<T> where T : Base
    {
        IQueryable<T> GetAll();
        T GetByID(int key);
        Task CreateAsync(T model);
        Task UpdateAsync(T model);
        void DeleteAsync(T model);
    }
}
