namespace DependencyInjection;

public class PayPalProcessor: IPaymentProcessor
{
    public string ProcessPayment(decimal amount) => $"Processed ${amount} via PayPal";
}