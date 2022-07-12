namespace DemoLibrary
{
    public class Logger : ILogger
    {
        public void Log(string description)
        {
            Console.WriteLine($"Write to the console: { description }.");
        }
    }

}