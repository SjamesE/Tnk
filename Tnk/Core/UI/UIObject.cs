using Tnk.Generics;

namespace Tnk.Core.UI
{
    internal class UIObject
    {
        public string name { get; private set; }
        public bool isActive { get; private set; }
        public RectTransform transform { get; private set; }

        private List<UIComponent> components = new List<UIComponent>();

        public UIObject(string name)
        {
            this.name = name;
            isActive = true;
            transform = new RectTransform();
        }

        public UIObject(string name, Vector2i position)
        {
            this.name = name;
            isActive = true;
            transform = new RectTransform(position);
        }

        public void AddComponent(UIComponent component)
        {
            components.Add(component);
        }

        public T GetComponent<T>() where T : UIComponent
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
