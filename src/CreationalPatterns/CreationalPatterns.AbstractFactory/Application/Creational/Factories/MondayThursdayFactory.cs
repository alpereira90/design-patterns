using CreationalPatterns.AbstractFactory.Application.Creational.Interfaces;
using CreationalPatterns.AbstractFactory.Application.Products.Diet;
using CreationalPatterns.AbstractFactory.Application.Products.Workout;

namespace CreationalPatterns.AbstractFactory.Application.Creational.Factories;

public class MondayThursdayFactory : IFactory
{
    public void GetDailyRoutine()
    {
        var diet = new DietMondayThursday();
        var workout = new MondayThursdayWorkout();

        diet.GetFeed();
        workout.GetWorkout();
    }
}