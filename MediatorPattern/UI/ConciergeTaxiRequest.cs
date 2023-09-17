namespace MediatorPattern.UI
{
    public class ConciergeTaxiRequest : ConciergeRequest
    {
        public ConciergeTaxiRequest()
        {
            Type = ConciergeType.Taxi;
        }

        public void Send()
        {
            service.Send(Type, "Consumer requested taxi.");
        }

        public override void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
