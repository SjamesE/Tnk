using SFML.Graphics;
using SFML.System;

namespace Tnk.Core
{
    internal class Renderer : Component
    {
        public Texture Texture { get; private set; }
        public Sprite Sprite { get; private set; }

        public Renderer(GameObject gameObject, Texture texture) : base(gameObject)
        {
            this.Texture = texture;

            Sprite = new Sprite
            {
                Texture = texture
            };
        }

        public void SetTexture(Texture texture)
        {
            Sprite.Texture = texture;
        }

        public void Render(RenderWindow window)
        {
            Sprite.Position = new Vector2f(Transform.Position.x, Transform.Position.y);
            Sprite.Scale = new Vector2f(Transform.Scale.x, Transform.Scale.y);
            Sprite.Rotation = Transform.Rotation;
            window.Draw(Sprite);
        }
    }
}
