using CreationalPatterns.FactoryMethod.Interfaces;

namespace CreationalPatterns.FactoryMethod.Services;

public class PremiumService :IService
{
    public void ExecuteBilling()
    {
        Console.WriteLine("Executing Billing for Premium Service.\n");
    }
}