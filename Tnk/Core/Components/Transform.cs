using Tnk.Generics;

namespace Tnk.Core
{
    internal class Transform : Component
    {
        public Vector2 position { get; set; }
        public float rotation { get; set; }
        public Vector2 scale { get; set; }

        public Transform(Object gameObject) : base(gameObject)
        {
            position = new Vector2();
            rotation = 0;
            scale = new Vector2();
        }
    }
}
