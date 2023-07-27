using CreationalPatterns.Singleton.Application.Contexts;

namespace CreationalPatterns.Singleton.Application;

public class Client
{
    public void ExecuteSomethingUsingDb()
    {
        var db = ContextsDb.GetInstance();
        db.Execute();
    }
}