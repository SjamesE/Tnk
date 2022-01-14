using SFML.Graphics;
using SFML.System;

namespace Tnk.Core
{
    internal class Renderer : Component
    {
        public Texture texture { get; private set; }
        public Sprite Sprite { get; private set; }

        public Renderer(GameObject gameObject, Texture texture) : base(gameObject)
        {
            this.texture = texture;

            Sprite = new Sprite(texture);
        }

        public void SetTexture(Texture texture)
        {
            Sprite.Texture = texture;
        }

        public void Render(RenderWindow window)
        {
            Sprite.Position = new Vector2f(transform.position.x, transform.position.y);
            Sprite.Scale = new Vector2f(transform.scale.x, transform.scale.y);
            Sprite.Rotation = transform.rotation;
            window.Draw(Sprite);
        }
    }
}
