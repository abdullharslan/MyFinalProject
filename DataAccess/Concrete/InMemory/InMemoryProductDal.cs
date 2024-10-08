using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal:IProductDal
{
    // Global olarak tanımlandığı için _product olarak veririz.
    List<Product> _products;
    
    /*
     * Bellekte referans aldığı zaman oluşacak olan bloktur.,nesnenin başlangıç durumunu
     * belirlemek ve gerekli başlangıç işlemlerini gerçekleştirmek için kullanılırlar.
     * ctor ile oluştururuz.
     */
    public InMemoryProductDal()
    {
        // Veritabanından geliyormuş gibi simule ediyoruz.
        _products = new List<Product>
        {
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitInStock = 15 },
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Kamera", UnitPrice = 500, UnitInStock = 3 },
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Telefon", UnitPrice = 1500, UnitInStock = 2 },
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Klavye", UnitPrice = 150, UnitInStock = 65 },
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Fare", UnitPrice = 85, UnitInStock = 1 }
        };
    }
    public List<Product> GetAll()
    {
        return _products;
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    // Kullanırken Id baz alarak istediğimiz kısımları güncelleyebiliyoruz.
    public void Update(Product product)
    {
        // Gönderdiğim ürün id'sine sahip olan ürün listedeki sahip ürünü bul ve güncelle.
        Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        productToUpdate.ProductName = product.ProductName;
        productToUpdate.CategoryId = product.CategoryId;
        productToUpdate.UnitPrice = product.UnitPrice;
        productToUpdate.UnitInStock = product.UnitInStock;
    }

    public void Delete(Product product)
    {
        /* Product productToDelete = null;
         * foreach (Product item in _products)
         * {
         *   if (product.ProductId == item.ProductId)
         *    {
         *        productToDelete = item;
         *    }
         * }
         * _products.Remove(productToDelete);
         */
        // LINQ - Language Integrated Query
        Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        _products.Remove(productToDelete);
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
        return _products.Where(p => p.CategoryId == categoryId).ToList();
    }
}