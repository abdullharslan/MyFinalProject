using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract;
// Generic Constraint
// class : referans tip
// IEntity :IEntity olabilir veya IEntity implemente eden bir nesne olabilir. 
// new() : newlenebilir olmalıdır. Artık IEntity koyamayız. Soyut nesne koyamayız artık.
public interface IEntityRepository<T> where T : class, IEntity, new()
{
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}