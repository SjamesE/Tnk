using Tnk.Generics;

namespace Tnk.Core
{
    internal class Transform : Component
    {
        public Vector2 Position { get; set; }
        public float Rotation { get; set; }
        public Vector2 Scale { get; set; }

        public Transform(Object gameObject) : base(gameObject)
        {
            Position = new Vector2();
            Rotation = 0;
            Scale = new Vector2();
        }
    }
}
