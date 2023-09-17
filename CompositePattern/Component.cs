namespace CompositePattern
{
    public abstract class Component
    {
        protected Component(string name, int version)
        {
            Name = name;
            Version = version;
        }

        public string Name { get; set; }

        public int Version { get; set; }

        public int Level { get; set; }

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public virtual void IncrementVersionForChildElements()
        {
            Version++;
        }

        public virtual void DecrementVersionForChildElements()
        {
            Version--;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{new string('-', Level + 1)} Name:{Name}, Version: {Version}, Level: {Level}");
        }
    }
}
