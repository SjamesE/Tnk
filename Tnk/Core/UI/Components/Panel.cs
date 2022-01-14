using SFML.Graphics;

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
            parent.AddComponent(this);

            texture = new Texture(1, 1);
            color = Color.Black;
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
            if (transform.size.x < 0 || transform.size.y < 0) return;
            Color[,] pixels = new Color[,]{ { Color.Black }, { Color.White },
                                            { Color.Red   }, { Color.Green },
                                            { Color.Blue  }, { Color.Cyan  }};
            Image image = new Image(pixels);

            texture = new Texture(image);
            sprite.Texture = texture;
            sprite.Scale = new SFML.System.Vector2f(10, 10);
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}
