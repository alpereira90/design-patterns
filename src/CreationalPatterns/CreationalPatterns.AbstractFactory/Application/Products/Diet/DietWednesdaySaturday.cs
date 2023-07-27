using CreationalPatterns.AbstractFactory.Application.Products.Interfaces;

namespace CreationalPatterns.AbstractFactory.Application.Products.Diet;

public class DietWednesdaySaturday : IDiet
{
    public void GetFeed()
    {
        Console.WriteLine("Diet from Wednesday and Saturday");
    }
}