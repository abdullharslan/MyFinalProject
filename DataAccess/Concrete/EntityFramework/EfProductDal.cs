using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : IProductDal
{
    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }
}