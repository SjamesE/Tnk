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

        public Panel(UIObject parent) : base(parent)
        {
            Initialize();
        }

        public Panel(UIObject parent, int x, int y) : base(parent)
        {
            transform.size = new Vector2i(x, y);
            Initialize();
        }

        public Panel(UIObject parent, Vector2i size) : base(parent)
        {
            transform.size = size;
            Initialize();
        }


        public void Initialize()
        {
            parent.AddComponent(this);    

            texture = new Texture(1, 1);
            color = Color.Black;
            customTexture = false;
            rounding = 0f;
            sprite = new Sprite();
            Update();
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
            Color[,] pixels = new Color[maxX, maxY];
            int _x = 0;
            int _y = 0;
            Random random = new Random();
            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    pixels[x, y] = new Color(0,//(byte)Maths.Normalize(_x, 0, maxX, 255),             
                                             (byte)Maths.Normalize(_y, 0, maxY, 255),             
                                             0);//(byte)Maths.Normalize(_x + _y, 0, maxX + maxY, 255));
                    _y++;
                }
                _x++;
                _y = 0;
            }

            Image image = new Image(pixels);

            texture = new Texture(image);
            sprite.Texture = texture;
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}
