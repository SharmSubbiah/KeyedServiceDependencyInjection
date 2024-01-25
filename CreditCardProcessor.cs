namespace DependencyInjection;

public class CreditCardProcessor : IPaymentProcessor
{
    public string ProcessPayment(decimal amount) => $"Processed ${amount} via Credit Card";
}