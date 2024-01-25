namespace DependencyInjection;

public class PayPalWrapper([FromKeyedServices("paypal")] IPaymentProcessor paypal)
{
    public string ProcessPaym(decimal amount) => paypal.ProcessPayment(amount);
}