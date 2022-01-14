namespace Tnk.Core
{
    internal abstract class Component
    {
        public Object parent { get; private set; }
        public Transform transform { get; private set; }


        public Component(Object gameObject)
        {
            parent = gameObject;
            transform = gameObject.Transform;
        }
    }
}
