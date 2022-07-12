namespace DemoLibrary
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string email)
        {
            // Simulate sending email
            Console.WriteLine($"Sending Email to { person.EmailAddress }");
        }
    }

}