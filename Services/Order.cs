using Shop.Models;

namespace Shop.Services;

public class Order
{
    private readonly List<(Product Product, int Quantity)> _lines = new();

    public IReadOnlyCollection<(Product Product, int Quantity)> Lines => _lines.AsReadOnly();

    public void AddItem(Product product, int quantity)
    {
        // product cannot be null
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        // quantity must be > 0
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity));
        }
    }

    public decimal Total()
    {
        decimal sum = 0m;
        foreach (var (p, q) in _lines)
        {
            checked
            {
                sum += p.Price * q;
            }
        }
        return sum;
    }
}