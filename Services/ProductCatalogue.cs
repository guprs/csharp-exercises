using Shop.Models;

namespace Shop.Services;

public class ProductCatalogue
{
    private readonly Dictionary<string, Product> _bySku = new();

    public void AddProduct(Product product)
    {
        _bySku[product.Sku] = product;

        // throw if product is null
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        // throw if SKU already exists
        if (_bySku.ContainsKey(product.Sku))
        {
            throw new ArgumentException("A product with this SKU already exists");
        }
    }

    public Product GetBySku(string sku)
    {
        // SKU cannot be null or empty
        if (string.IsNullOrWhiteSpace(sku))
        {
            throw new ArgumentException("SKU cannot be empty", nameof(sku));
        }

        // SKU must exist
        if (!_bySku.ContainsKey(sku))
        {
            throw new KeyNotFoundException($"Product with SKU '{sku}' was not found.");
        }

        return _bySku[sku];
    }
}