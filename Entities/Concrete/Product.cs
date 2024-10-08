using Entities.Abstract;

namespace Entities.Concrete;

// Public bu class'a diğer katmanlarda ulaşabilsin demektir.
public class Product:IEntity
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public short UnitInStock { get; set; }
    public decimal UnitPrice { get; set; }
}