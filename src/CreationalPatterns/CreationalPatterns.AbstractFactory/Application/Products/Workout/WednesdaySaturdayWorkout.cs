using CreationalPatterns.AbstractFactory.Application.Products.Interfaces;

namespace CreationalPatterns.AbstractFactory.Application.Products.Workout;

public class WednesdaySaturdayWorkout : IWorkout
{
    public WednesdaySaturdayWorkout()
    {
        GetWorkout();
    }

    public void GetWorkout()
    {
        Console.WriteLine("Workout from and Wednesday and Saturday");
    }
}