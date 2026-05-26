namespace Shop.Payments;

public class PaymentProcessor
{
    // simulated rule set for the exercise
    public void Charge(string cardNumber, decimal amount)
    {
        // throw when cardNumber is null
        if(cardNumber == null)
        {
            throw new ArgumentNullException(nameof(cardNumber));
        }

        // throw if cardNumber null or empty
        if (string.IsNullOrWhiteSpace(cardNumber))
        {
            throw new ArgumentNullException("Card Number cannot be empty", nameof(cardNumber));
        }

        // throw if amount <= 0
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException("The amount must be greater than zero.");
        }

        // simulate business rules that trigger custom exception:
        if (amount > 1000m)
        {
            throw new PaymentDeclinedException("Payment declined.", "Limit exceeded.", amount);
        }

        if (cardNumber.StartsWith("0000"))
        {
            throw new PaymentDeclinedException("Payment declined.", "Invalid Card.", amount);
        }
    }
}