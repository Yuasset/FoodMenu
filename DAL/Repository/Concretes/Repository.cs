
using DAL.Models.Abstracts;
using DAL.Models.Concretes;
using DAL.Repository.Abstracts;

namespace DAL.Repository.Concretes
{
    public class Repository<T> : IRepository<T> where T : Base
    {
        private readonly FoodContext foodContext;

        public Repository(FoodContext foodContext)
        {
            this.foodContext = foodContext;
        }

        public async Task CreateAsync(T model)
        {
            await foodContext.Set<T>().AddAsync(model);
            await foodContext.SaveChangesAsync();
        }

        public void DeleteAsync(T model)
        {
            foodContext.Set<T>().Remove(model);
            foodContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return foodContext.Set<T>();
        }

        public T GetByID(int key)
        {
            return foodContext.Set<T>().Find(key);
        }

        public async Task UpdateAsync(T model)
        {
            var tempData = await foodContext.Set<T>().FindAsync(model.ID);
            foodContext.Entry(tempData).CurrentValues.SetValues(model);
            await foodContext.SaveChangesAsync();
        }
    }
}
