using SFML.Graphics;
using Tnk.Generics;

namespace Tnk.Core.UI
{
    internal class Panel : UIComponent
    {
        public Texture texture { get; private set; }
        public Sprite sprite { get; private set; }
        public Vector2i center { get; private set; }
        public bool customTexture { get; private set; }
        public Color color { get; private set; }
        public int rounding  { get; private set; }
        public int borderSize { get; private set; }
        private Color[,] pixels = new Color[0,0];
        private Image image = new Image(0,0);

        public Panel(UIObject parent) : base(parent)
        {
            parent.AddComponent(this);

            texture = new Texture((uint)transform.size.x, (uint)transform.size.y);
            color = Color.White;
            customTexture = false;
            rounding = 0;
            sprite = new Sprite();
            Update();
        }

        private void Update()
        {
            if (transform.size.x <= 0 || transform.size.y <= 0) return;
            Vector2i size = parent.transform.size;
            int maxX = size.x;
            int maxY = size.y;

            // Update each pixel in the Panel
            pixels = new Color[maxX, maxY];
            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    if (!IsPixelOnTheEdge(x, y))
                    {
                        if (x < borderSize || x > size.x - borderSize - 1 || y < borderSize || y >= size.y - borderSize)
                            pixels[x, y] = new Color(150, 150, 150, 255);
                        else
                        {
                            if (IsPixelOnTheEdge(x, y, borderSize))
                            {
                                pixels[x, y] = new Color(150, 150, 150, 255);
                            }
                            else
                                pixels[x, y] = color;
                        }
                    }
                    else
                        pixels[x, y] = new Color(0, 0, 0, 0);
                }
            }

            // Update the texture from the Pixels
            image = new Image(pixels);
            texture.Dispose();
            texture = new Texture(image);
            sprite.Texture = texture;

            // Update Position
            Vector2i pos = new Vector2i(parent.transform.position.x, parent.transform.position.y);
            sprite.Position = new SFML.System.Vector2f(pos.x, pos.y);
            center = new Vector2i(pos.x + size.x / 2, pos.y + size.y / 2);
        }

        public virtual void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }

        private bool IsPixelOnTheEdge(int x, int y, int offset = 0)
        {
            Vector2i size = parent.transform.size;
            if (rounding == 0) return false;
            int minSize = (size.x > size.y) ? size.y / 2 : size.x / 2;
            if (rounding > minSize)
                rounding = minSize;

            if (x < rounding && y < rounding)
            {
                bool tooFar = (GetDistance(new Vector2(x, y), new Vector2(rounding + offset, rounding + offset)) > rounding) ? true : false;
                return tooFar;
            }
            if (x > size.x - rounding && y < rounding)
            {
                bool tooFar = (GetDistance(new Vector2(x, y), new Vector2(size.x - rounding - offset, rounding + offset)) > rounding) ? true : false;
                return tooFar;
            }
            if (x > size.x - rounding && y > size.y - rounding)
            {
                bool tooFar = (GetDistance(new Vector2(x, y), new Vector2(size.x - rounding - offset, size.y - rounding - offset)) > rounding) ? true : false;
                return tooFar;
            }
            if (x < rounding && y > size.y - rounding)
            {
                bool tooFar = (GetDistance(new Vector2(x, y), new Vector2(rounding + offset, size.y - rounding - offset)) > rounding) ? true : false;
                return tooFar;
            }


            return false;
        }

        private float GetDistance(Vector2 left, Vector2 right)
        {
            float h = MathF.Abs(right.y - left.y);
            float v = MathF.Abs(right.x - left.x);
            return MathF.Sqrt((h * h) + (v * v));
        }

        #region Setters
        public void SetPosition(int x, int y)
        {
            parent.transform.position = new Vector2i(x, y);
            Update();
        }

        public void SetColor(Color color)
        {
            this.color = color;
            Update();
        }

        public void SetRounding(int rounding)
        {
            this.rounding = rounding;
            Update();
        }

        public void SetBorderSize(int borderSize)
        {
            this.borderSize = borderSize;
            Update();
        }
        #endregion
    }
}
