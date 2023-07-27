using CreationalPatterns.AbstractFactory.Application.Products.Interfaces;

namespace CreationalPatterns.AbstractFactory.Application.Products.Workout;

public class TuesdayFridayWorkout : IWorkout
{
    public void GetWorkout()
    {
        Console.WriteLine("Workout from Tuesday and Friday");
    }
}