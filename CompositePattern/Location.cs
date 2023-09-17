namespace CompositePattern
{
    public class Location : Component
    {
        private readonly List<Component> childLocations = new();

        public Location(string name, int version) : base(name, version)
        {
        }

        public override void Add(Component component)
        {
            component.Level = Level + 1;
            childLocations.Add(component);
        }

        public override void Remove(Component component)
        {
            childLocations.Remove(component);
        }

        public override void IncrementVersionForChildElements()
        {
            base.IncrementVersionForChildElements();
            foreach (var location in childLocations)
            {
                location.IncrementVersionForChildElements();
            }
        }

        public override void DecrementVersionForChildElements()
        {
            base.DecrementVersionForChildElements();
            foreach (var location in childLocations)
            {
                location.DecrementVersionForChildElements();
            }
        }

        public override void Display()
        {
            base.Display();
            foreach (var location in childLocations)
            {
                location.Display();
            }
        }
    }
}
