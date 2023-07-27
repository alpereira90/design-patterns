using CreationalPatterns.AbstractFactory.Application.Creational.Interfaces;
using CreationalPatterns.AbstractFactory.Application.Products.Diet;
using CreationalPatterns.AbstractFactory.Application.Products.Workout;

namespace CreationalPatterns.AbstractFactory.Application.Creational.Factories;

public class TuesdayFridayFactory : IFactory
{
    public void GetDailyRoutine()
    {
        var diet = new DietTuesdayFriday();
        var workout = new TuesdayFridayWorkout();

        diet.GetFeed();
        workout.GetWorkout();
    }
}