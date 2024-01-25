namespace DependencyInjection;

public interface IPaymentProcessor
{
    string ProcessPayment(decimal amount);
}