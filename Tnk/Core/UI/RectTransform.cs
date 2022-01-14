using Tnk.Generics;

namespace Tnk.Core.UI
{
    internal class RectTransform
    {
        public Vector2i position;
        public Vector2i size;

        public RectTransform()
        {
            position = new Vector2i();
            size = new Vector2i();
        }

        public RectTransform(Vector2i position)
        {
            this.position = position;
            size = new Vector2i();
        }

        public RectTransform(Vector2i position, Vector2i size)
        {
            this.position = position;
            this.size = size;
        }
    }
}
