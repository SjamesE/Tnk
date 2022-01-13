namespace Tnk.Core
{
    internal class Scene
    {
        public string Name { get; private set; }
        public int SceneIndex { get; private set; }
        public List<GameObject> GameObjects { get; private set; }

        public Scene(string name, int index)
        {
            Name = name;
            SceneIndex = index;
            GameObjects = new List<GameObject>();
        }

        public void AddGameObject(GameObject gameObject)
        {
            GameObjects.Add(gameObject);
        }

        public bool RemoveObject(GameObject gameObject)
        {
            return GameObjects.Remove(gameObject);
        }
    }
}
