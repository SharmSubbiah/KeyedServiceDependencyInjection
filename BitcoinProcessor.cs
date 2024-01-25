namespace DependencyInjection;

public class BitcoinProcessor : IPaymentProcessor
{
    public string ProcessPayment(decimal amount) => $"Processed ${amount} via Bitcoin";
}