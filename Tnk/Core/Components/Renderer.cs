using SFML.Graphics;
using SFML.System;

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
            sprite.Position = new Vector2f(transform.position.x, transform.position.y);
            window.Draw(sprite);
        }
    }
}
