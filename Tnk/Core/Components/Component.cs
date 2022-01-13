namespace Tnk.Core
{
    internal abstract class Component
    {
        public Object Parent { get; private set; }
        public Transform Transform { get; private set; }


        public Component(Object gameObject)
        {
            Parent = gameObject;
            Transform = gameObject.Transform;
        }
    }
}
