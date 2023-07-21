using CreationalPatterns.FactoryMethod.Interfaces;

namespace CreationalPatterns.FactoryMethod.Services;

public class MasterService :IService
{
    public void ExecuteBilling()
    {
        Console.WriteLine("Executing Billing for Master Service.\n");
    }
}