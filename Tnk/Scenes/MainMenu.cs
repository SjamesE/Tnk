using Tnk.Core;

namespace Tnk.Scenes.Menu
{
    internal class MainMenu
    {
        private Scene mainMenu;
        public readonly int sceneIndex = 0;

        public MainMenu()
        {
            mainMenu = SceneManager.CreateScene("MainMenu");

        }
    }
}
