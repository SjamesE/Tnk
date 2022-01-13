using SFML.Graphics;

namespace Tnk.Core
{
    internal class Render
    {
        RenderWindow window;

        public Render(RenderWindow window)
        {
            this.window = window;
        }

        public void Draw(Scene scene)
        {
            List<GameObject> objects = scene.GameObjects;

            window.Clear();

            foreach (GameObject obj in objects)
            {
                obj.GetComponent<Renderer>().Render(window);
            }

            window.Display();
        }
    }
}
