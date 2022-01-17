using Tnk.Generics;

namespace Tnk.Core.UI
{
    internal class RectTransform
    {
        public enum HorizontalAlignment
        {
            none,
            left,
            centre,
            right
        }
        public enum VerticalAlignment
        {
            none,
            top,
            centre,
            bottom
        }

        public Vector2i position;
        public Vector2i size;
        public HorizontalAlignment horizontalAlignment;
        public VerticalAlignment verticalAlignment;

        public RectTransform(Vector2i size, HorizontalAlignment ha = HorizontalAlignment.centre, VerticalAlignment va = VerticalAlignment.centre)
        {
            position = new Vector2i();
            size = new Vector2i();
            horizontalAlignment = ha;
            verticalAlignment = va;
        }

        public RectTransform(Vector2i position, Vector2i size, HorizontalAlignment ha = HorizontalAlignment.centre, VerticalAlignment va = VerticalAlignment.centre)
        {
            this.position = position;
            this.size = size;
            horizontalAlignment = ha;
            verticalAlignment = va;
        }

        private void UpdatePosition()
        {
            if (horizontalAlignment == HorizontalAlignment.centre)
            {

            }
        }
    }
}
