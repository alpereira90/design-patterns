using CreationalPatterns.FactoryMethod.Enums;

namespace DesignPatterns.Creational.FactoryMethod;

public class Client
{
    public void ExecuteService()
    {
        var selector = new ServiceFactoryImpl();

        while (true)
        {
            Console.WriteLine("Select the service type:\n");
            Console.WriteLine("0 - Traditional");
            Console.WriteLine("1 - Premium");
            Console.WriteLine("2 - Master");
            Console.WriteLine("3 - Top");

            Console.Write("Service type: ");
            var serviceType = Convert.ToInt32(Console.ReadLine());

            var service = selector.Create((ServiceType)serviceType);

            if (service == null) Console.WriteLine("Invalid Service! \n");
            else service.ExecuteBilling();
        }
    }
}