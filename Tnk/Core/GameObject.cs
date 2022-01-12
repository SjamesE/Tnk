namespace Tnk.Core
{
    internal abstract class GameObject
    {
        public string name;
        public Transform transform { get; set; }

        public bool isActive = true;

        private List<Component> components = new List<Component>();

        public GameObject(string name)
        {
            this.name = name;
            transform = new Transform(this);
            components.Add(transform);
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }

        public Component GetComponent(Type type)
        {
            foreach (Component component in components)
            {
                if (type == component.GetType())
                    return component;
            }
            return null;
        }
    }
}
