namespace DependencyInjection;

public class CreditCardWrapper([FromKeyedServices("creditCard")] IPaymentProcessor creditcard)
{
    public string ProcessPaym(decimal amount) => creditcard.ProcessPayment(amount);
}