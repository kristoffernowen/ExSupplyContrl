using System.Linq.Expressions;

namespace Core
{
    public interface IRepositoryBase<T>
    {
        List<T> Get();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
