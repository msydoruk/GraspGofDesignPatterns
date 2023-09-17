namespace MediatorPattern
{
    public class ConciergeService : IService
    {
        private Dictionary<ConciergeType, ConciergeRequest> conciergeRequests = new();

        public void Send(ConciergeType conciergeType, string message)
        {
            var request = conciergeRequests[conciergeType];

            if (request != null)
                request.Notify($"{request.Type} ordered.");
        }

        public void Register(ConciergeRequest conciergeRequest)
        {
            if (!conciergeRequests.ContainsKey(conciergeRequest.Type))
            {
                conciergeRequests.Add(conciergeRequest.Type, conciergeRequest);
                conciergeRequest.SetService(this);
            }
        }
    }
}
