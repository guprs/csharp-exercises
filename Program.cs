using Shop.Models;
using Shop.Services;
using Shop.Payments;

var catalogue = new ProductCatalogue();
var processor = new PaymentProcessor();

// happy-path product
var valid = new Product("ABC-123", "Coffee Mug", 12.50m);

// add to catalogue
catalogue.AddProduct(valid);

// lookup and order
var order = new Order();
var fetched = catalogue.GetBySku("ABC-123");
order.AddItem(fetched, 2);

Console.WriteLine($"Order total: {order.Total():0.00}");

// intentionally provoke failures and handle them here:

try
{
    //missing SKU
    var missing = catalogue.GetBySku("DOES-NOT-EXIST");
}
catch (KeyNotFoundException ex)
{
    Console.WriteLine($"Catalogue error: {ex.Message}");
}

try
{
    // invalid quantity
    order.AddItem(fetched, 0);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Order error: {ex.Message}");
}

try
{
    // payment scenarios
    processor.Charge("0000-1111-2222-3333", order.Total()); // likely to be declined
    processor.Charge("4444-5555-6666-7777", -10m); // invalid amount
}
catch (PaymentDeclinedException ex)
{
    Console.WriteLine($"Payment declined: {ex.Reason} (Amount={ex.Amount})");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Bad argument: {ex.Message}");
}
catch (Exception ex)
{
    // last-resort catch to avoid crashing the app in the exercise
    Console.WriteLine($"Unexpected errro: {ex.Message}");
}
finally
{
    Console.WriteLine("End of payment attempt.");
}

Console.WriteLine("DONE.");