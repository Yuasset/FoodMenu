using BLL.Services.Abstracts;
using DAL.Models.Abstracts;
using DAL.Repository.Abstracts;

namespace BLL.Services.Concretes
{
    public class ServiceManager<T> : IServiceManager<T> where T : Base
    {
        private readonly IRepository<T> repository;

        public ServiceManager(IRepository<T> repository)
        {
            this.repository = repository;
        }
        public async Task CreateAsync(T model)
        {
            if (model != null)
            {
                await repository.CreateAsync(model);
            }
            else
            {
                throw new ArgumentNullException(nameof(model));
            }
        }

        public void DeleteAsync(T model)
        {
            if (model != null)
            {
                repository.DeleteAsync(model);
            }
            else
            {
                throw new ArgumentNullException(nameof(model));
            }
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public T GetByID(int key)
        {
            return repository.GetByID(key);
        }

        public async Task UpdateAsync(T model)
        {
            if (model != null)
            {
                await repository.UpdateAsync(model);
            }
            else
            {
                throw new ArgumentNullException(nameof(model));
            }
        }
    }
}
