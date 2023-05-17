using Core;

namespace Data
{
    internal abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContext DataContext;
        public RepositoryBase(DataContext dataContext)
            => DataContext = dataContext;


        public List<T> Get()
        {
            return DataContext.Set<T>().ToList();
        }

        public void Create(T entity) => DataContext.Set<T>().Add(entity);
        public void Update(T entity) => DataContext.Set<T>().Update(entity);
        public void Delete(T entity) => DataContext.Set<T>().Remove(entity);
        public void Save()
        {
            DataContext.SaveChanges();
        }
    }
}
