using CreationalPatterns.AbstractFactory.Application.Products.Interfaces;

namespace CreationalPatterns.AbstractFactory.Application.Products.Diet;

public class DietTuesdayFriday : IDiet
{
    public void GetFeed()
    {
        Console.WriteLine("Diet from Tuesday and Friday");
    }
}