namespace Tnk.Core
{
    internal abstract class Component
    {
        GameObject parent;
        Transform transform;

        public Component(GameObject gameObject)
        {
            parent = gameObject;
            transform = gameObject.transform;
        }
    }
}
