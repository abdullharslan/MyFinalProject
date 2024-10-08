using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    // Ne EntityFramework ne de InMemory ismi geçecek.  
    IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }
    public List<Product> GetAll()
    {
        // İş kodları. Bir iş sınıfları başka sınıfları newlemez.
        return _productDal.GetAll();
    }
}