using SFML.Graphics;

namespace Tnk.Core
{
    internal class Renderer : Component
    {
        public Texture texture { get; private set; }
        public Sprite sprite { get; private set; }

        public Renderer(GameObject gameObject, Texture texture) : base(gameObject)
        {
            this.texture = texture;
        
            sprite = new Sprite();
            sprite.Texture = texture;
        }

        public void SetTexture(Texture texture)
        {
            sprite.Texture = texture;
        }

        public void Render(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}
