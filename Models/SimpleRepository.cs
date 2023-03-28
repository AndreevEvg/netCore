using System.Collections.Generic;

namespace Razor.Models;

public class SimpleRepository : IRepository
{
    private readonly Dictionary<string, Product> _products = new Dictionary<string, Product>();

    public static SimpleRepository SharedRepository { get; } = new SimpleRepository();

    private SimpleRepository()
    {
        var initialItems = new[]
        {
            new Product { Name = "Kayak", Price = 275M },
            new Product { Name = "Lifejacket", Price = 48.95M },
            new Product { Name = "Soccer ball", Price = 19.50M },
            new Product { Name = "Corner flag", Price = 34.95M },
        };

        foreach (var p in initialItems)
        {
            AddProduct(p);
        }
        _products.Add("Error", null!);
    }

    public IEnumerable<Product> Products => _products.Values;

    public void AddProduct(Product p) => _products.Add(p.Name, p);
}