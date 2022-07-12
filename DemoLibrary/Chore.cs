namespace DemoLibrary
{
    public class Chore : IChore
    {
        private ILogger _logger;
        private IMessageSender _emailer;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }
        public Chore(ILogger logger, IMessageSender emailer)
        {
            _logger = logger;
            _emailer = emailer;
        }
        public void PerformedChore(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChoreName }");
            return;
        }
        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Completed chore { ChoreName }");
            _emailer.SendMessage(Owner, $"The chore { ChoreName } is completed.");
            return;
        }
    }

}