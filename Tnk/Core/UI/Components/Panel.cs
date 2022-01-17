using SFML.Graphics;
using Tnk.Generics;
using Tnk.Core.Math;

namespace Tnk.Core.UI
{
    internal class Panel : UIComponent
    {
        public Texture texture { get; private set; }
        public Sprite sprite { get; private set; }
        public bool customTexture { get; private set; }
        public Color color { get; private set; }
        public float rounding  { get; private set; }
        Color[,] pixels;
        Image image;
        float dt = 0;
        bool add = true;

        public Panel(UIObject parent) : base(parent)
        {
            parent.AddComponent(this);

            texture = new Texture((uint)transform.size.x, (uint)transform.size.y);
            color = Color.Black;
            customTexture = false;
            rounding = 0f;
            sprite = new Sprite();
            Update();
        }

        public void SetPosition(int x, int y)
        {
            parent.transform.position = new Vector2i(x, y);
        }

        public void SetColor(Color color)
        {
            this.color = color;
            Update();
        }

        public void SetRounding(float rounding)
        {
            this.rounding = rounding;
            Update();
        }

        public void Update()
        {
            if (transform.size.x <= 0 || transform.size.y <= 0) return;
            int maxX = (int)transform.size.y;
            int maxY = (int)transform.size.x;
            pixels = new Color[maxX, maxY];
            if (add)
            {
                dt += Time.fixedDeltaTime;
                if (dt >= 1)
                {
                    dt = 1;
                    add = false;
                }
            }
            else
            {
                dt -= Time.fixedDeltaTime;
                if (dt <= 0)
                {
                    dt = 0;
                    add = true;
                }
            }
            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    pixels[x, y] = new Color((byte)Maths.Lerp(0, 255, dt),
                                             (byte)Maths.Lerp(0, 255, dt),
                                             (byte)Maths.Lerp(0, 255, dt));
                    //pixels[x, y] = new Color();

                }
            }

            image = new Image(pixels);
            texture.Dispose();
            texture = new Texture(image);
            sprite.Texture = texture;
            sprite.Position = new SFML.System.Vector2f(parent.transform.position.x, parent.transform.position.y);
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}
