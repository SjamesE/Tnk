using SFML.Graphics;
using Tnk.Core.UI;

namespace Tnk.Core
{
    internal class Scene
    {
        public string name { get; private set; }
        public int sceneIndex { get; private set; }
        public List<GameObject> gameObjects { get; private set; }
        public List<UIObject> uiObjects { get; set; }
        private RenderWindow window;

        public Scene(RenderWindow window, string name, int index)
        {
            this.window = window;
            this.name = name;
            sceneIndex = index;
            gameObjects = new List<GameObject>();
            uiObjects = new List<UIObject>();
        }

        public void AddGameObject(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public bool RemoveGameObject(GameObject gameObject)
        {
            return gameObjects.Remove(gameObject);
        }

        public void AddUIObject(UIObject uiObject)
        {
            uiObjects.Add(uiObject);
        }

        public bool RemoveUIObject(UIObject uiObject)
        {
            return uiObjects.Remove(uiObject);
        }
    }
}
