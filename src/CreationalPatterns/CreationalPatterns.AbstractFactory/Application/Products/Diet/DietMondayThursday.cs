using CreationalPatterns.AbstractFactory.Application.Products.Interfaces;

namespace CreationalPatterns.AbstractFactory.Application.Products.Diet;

public class DietMondayThursday : IDiet
{
    public void GetFeed()
    {
        Console.WriteLine("Diet from Monday and Thursday");
    }
}