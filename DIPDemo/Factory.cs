// See https://aka.ms/new-console-template for more information
using DemoLibrary;
public class Factory
{
    public static IPerson CreatePerson()
    {
        return new Person();
    }

    public static IChore CreateChore()
    {
        return new Chore(CreateLogger(), CreateMessageSender());
    }

    public static ILogger CreateLogger()
    {
        return new Logger();
    }
    public static IMessageSender CreateMessageSender()
    {
        return new Texter();
    }
}