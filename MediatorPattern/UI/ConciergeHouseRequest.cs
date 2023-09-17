namespace MediatorPattern.UI
{
    public class ConciergeHouseRequest : ConciergeRequest
    {
        public ConciergeHouseRequest()
        {
            Type = ConciergeType.House;
        }

        public void Send()
        {
            service.Send(Type, "Consumer requested house master.");
        }

        public override void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
