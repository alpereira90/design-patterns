using CreationalPatterns.AbstractFactory.Application.Products.Interfaces;

namespace CreationalPatterns.AbstractFactory.Application.Products.Workout;

public class MondayThursdayWorkout : IWorkout
{
    public void GetWorkout()
    {
        Console.WriteLine("Workout from Monday and Thursday");
    }
}