using CreationalPatterns.AbstractFactory.Application.Creational.Factories;
using CreationalPatterns.AbstractFactory.Application.Creational.Interfaces;

namespace CreationalPatterns.AbstractFactory.Application;

public class Client
{
    private readonly Dictionary<string, Type> _map = new()
    {
        { "1", typeof(MondayThursdayFactory) },
        { "2", typeof(TuesdayFridayFactory) },
        { "3", typeof(WednesdaySaturdayFactory) }
    };

    public void RetrieveRoutine()
    {
        while (true)
        {
            Console.WriteLine("Select the routine: ");
            Console.WriteLine("1 - Monday and Thursday");
            Console.WriteLine("2 - Tuesday and Friday");
            Console.WriteLine("3 - Wednesday and Saturday");

            var selected = Console.ReadLine();

            var factory = _map.TryGetValue(selected, out var type) ? Activator.CreateInstance(type) as IFactory : null;
            if (factory == null) throw new Exception("invalid option");

            factory.GetDailyRoutine();
        }
    }
}