namespace CreationalPatterns.Singleton.Application.Contexts;

public class ContextsDb
{
    private static ContextsDb? _instance;

    private ContextsDb()
    {
        Console.WriteLine("Context Created");
    }

    public static ContextsDb GetInstance()
    {
        return _instance ??= new ContextsDb();
    }

    public void Execute()
    {
        Console.WriteLine("Executed...");
    }
}