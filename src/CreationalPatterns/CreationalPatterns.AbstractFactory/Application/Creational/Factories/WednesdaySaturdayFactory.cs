using CreationalPatterns.AbstractFactory.Application.Creational.Interfaces;
using CreationalPatterns.AbstractFactory.Application.Products.Diet;
using CreationalPatterns.AbstractFactory.Application.Products.Workout;

namespace CreationalPatterns.AbstractFactory.Application.Creational.Factories;

public class WednesdaySaturdayFactory : IFactory
{
    public void GetDailyRoutine()
    {
        var diet = new DietWednesdaySaturday();
        var workout = new WednesdaySaturdayWorkout();

        diet.GetFeed();
        workout.GetWorkout();
    }
}