namespace MediatorPattern
{
    public interface IService
    {
        public void Send(ConciergeType conciergeType, string message);

        public void Register(ConciergeRequest conciergeRequest);
    }
}
