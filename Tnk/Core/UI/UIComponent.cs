namespace Tnk.Core.UI
{
    internal abstract class UIComponent
    {
        public UIObject parent { get; private set; }
        public RectTransform transform { get; private set; }

        public UIComponent(UIObject parent)
        {
            this.parent = parent;
            transform = parent.transform;
        }
    }
}
