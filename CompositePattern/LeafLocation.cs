namespace CompositePattern
{
    internal class LeafLocation : Component
    {
        public LeafLocation(string name, int version) : base(name, version)
        {
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
