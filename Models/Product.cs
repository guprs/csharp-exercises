using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace Shop.Models;

public class Product
{
    public string Sku { get; }
    public string Name { get; }
    public decimal Price { get; }

    public Product(string sku, string name, decimal price)
    {
        Sku = sku;
        Name = name;
        Price = price;

        // sku and name must not be null or whitespace
        if (string.IsNullOrWhiteSpace(sku))
        {
            throw new ArgumentException("Sku cannot be empty", nameof(sku));
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty", nameof(name));
        }

        // price must be > 0
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException("Price must be greater than zero");
        }
    }
}