using Tnk.Generics;

namespace Tnk.Core
{
    internal class Transform : Component
    {
        public Vector2 position { get; set; }
        public Vector2 rotation { get; set; }
        public Vector2 scale { get; set; }

        public Transform(GameObject gameObject) : base(gameObject)
        {
            position = new Vector2();
            rotation = new Vector2();
            scale = new Vector2();
        }
    }
}
