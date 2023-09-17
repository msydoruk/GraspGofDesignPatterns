namespace MediatorPattern
{
    public abstract class ConciergeRequest
    {
        protected IService service;

        public ConciergeType Type { get; set; }

        public abstract void Notify(string message);

        public void SetService(IService service)
        {
            this.service = service;
        }
    }
}
