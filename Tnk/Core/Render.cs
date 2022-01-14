using SFML.Graphics;
using Tnk.Core.UI;

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
            List<GameObject> objects = scene.gameObjects;
            List<UIObject> uiObjects = scene.uiObjects;

            window.Clear();

            foreach (GameObject obj in objects)
            {
                obj.GetComponent<Renderer>().Render(window);
            }
            foreach (UIObject obj in uiObjects)
            {
                obj.GetComponent<Panel>().Draw(window);
            }

            window.Display();
        }
    }
}
