namespace MediatorPattern.UI
{
    public class ConciergeFlowersRequest : ConciergeRequest
    {
        public ConciergeFlowersRequest()
        {
            Type = ConciergeType.Flower;
        }

        public void Send()
        {
            service.Send(Type, "Consumer requested flowers.");
        }

        public override void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
