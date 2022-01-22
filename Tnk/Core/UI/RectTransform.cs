using SFML.Graphics;
using Tnk.Generics;

namespace Tnk.Core.UI
{
    internal class RectTransform
    {
        public enum HAlign
        {
            none,
            left,
            centre,
            right
        }
        public enum VAlign
        {
            none,
            top,
            centre,
            bottom
        }

        public Vector2i position;
        public Vector2i size;
        public HAlign hAlign;
        public VAlign vAlign;

        private RenderWindow window;

        public RectTransform(RenderWindow window, Vector2i size, HAlign ha = HAlign.centre, VAlign va = VAlign.centre)
        {
            this.size = size;
            this.window = window;
            hAlign = ha;
            vAlign = va;
            UpdatePos();
        }

        public RectTransform(RenderWindow window, Vector2i position, Vector2i size)
        {
            this.size = size;
            this.window = window;
            hAlign = HAlign.none;
            vAlign = VAlign.none;
            this.position = position;
        }

        private void UpdatePos()
        {
            switch (hAlign)
            {
                case HAlign.none:
                    break;
                case HAlign.left:
                    position.x = 0;
                    break;
                case HAlign.centre:
                    position.x = (int)window.Size.X / 2 - size.x / 2;
                    break;
                case HAlign.right:
                    position.x = (int)window.Size.X - size.x;
                    break;
                default:
                    break;
            }
            switch (vAlign)
            {
                case VAlign.none:
                    break;
                case VAlign.top:
                    position.y = 0;
                    break;
                case VAlign.centre:
                    position.y = (int)window.Size.Y / 2 - size.y / 2;
                    break;
                case VAlign.bottom:
                    position.y = (int)window.Size.Y - size.y;
                    break;
                default:
                    break;
            }
        }
    }
}
