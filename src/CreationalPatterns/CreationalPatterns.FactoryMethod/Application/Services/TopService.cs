using CreationalPatterns.FactoryMethod.Interfaces;

namespace CreationalPatterns.FactoryMethod.Services;

public class TopService : IService
{
    public void ExecuteBilling()
    {
        Console.WriteLine("Executing Billing for Top Service.\n");
    }
}