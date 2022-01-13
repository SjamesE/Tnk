namespace Tnk.Core
{
    internal abstract class Object
    {
        public string name;
        public Object? parent;
        public Transform Transform
        {
            get
            {
                return (parent == null) ? Transform : parent.Transform;
            }
            private set
            {
                Transform = value;
            }
        }

        public bool isActive = true;

        private List<Component> components = new List<Component>();

        public Object(string name, Object? parent = null)
        {
            this.name = name;

            Transform = new Transform(this);
            components.Add(Transform);

            this.parent = parent;
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }

        public T GetComponent<T>() where T : Component
        {
            foreach (var component in components)
            {
                if (component is T value)
                    return value;
            }
            return null;
        }
    }
}
