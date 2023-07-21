using CreationalPatterns.FactoryMethod.Interfaces;

namespace CreationalPatterns.FactoryMethod.Services;

public class TraditionalService :IService
{
    public void ExecuteBilling()
    {
        Console.WriteLine("Executing Billing for Traditional Service.\n");
    }
}