namespace Tnk.Core
{
    internal abstract class Component
    {
        public GameObject parent { get; private set; }
        public Transform transform { get; private set; }


        public Component(GameObject gameObject)
        {
            parent = gameObject;
            transform = gameObject.transform;
        }
    }
}
