using SFML.Graphics;
using Tnk.Generics;
using static Tnk.Core.UI.RectTransform;

namespace Tnk.Core.UI
{
    internal class UIObject
    {
        public string name { get; private set; }
        public bool isActive { get; private set; }
        public RectTransform transform { get; private set; }

        private List<UIComponent> components = new List<UIComponent>();

        public UIObject(RenderWindow window, string name, Vector2i size, HAlign hAlign, VAlign vAlign)
        {
            this.name = name;
            isActive = true;
            transform = new RectTransform(window, size);
        }

        public UIObject(RenderWindow window, string name, Vector2i size)
        {
            this.name = name;
            isActive = true;
            transform = new RectTransform(window, size);
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
