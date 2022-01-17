using SFML.Graphics;

namespace Tnk.Core
{
    internal static class SceneManager
    {
        private static List<Scene> scenes;
        public static int ActiveSceneIndex { get; private set; }

        static SceneManager()
        {
            scenes = new List<Scene>();
        }

        public static Scene GetActiveScene()
        {
            if (scenes.Count == 0) throw new InvalidOperationException("No scene exists.");
            return scenes[ActiveSceneIndex];
        }

        public static Scene GetScene(int index)
        {
            if (index > scenes.Count - 1 || index < 0)
                throw new ArgumentException("Scene index out of bounds");
            return scenes.ElementAt(index);
        }

        public static Scene CreateScene(RenderWindow window, string name)
        {
            scenes.Add(new Scene(window, name, scenes.Count));
            return scenes.ElementAt(scenes.Count - 1);
        }

        public static void DeleteScene(int index)
        {
            if (index > scenes.Count - 1 || index < 0)
                throw new ArgumentException("Scene index out of bounds");
            scenes.RemoveAt(index);
        }

        public static void ChangeActiveScene(int index)
        {
            if (index > scenes.Count - 1 || index < 0)
                throw new ArgumentException("Scene index out of bounds");

            ActiveSceneIndex = index;
        }
    }
}
