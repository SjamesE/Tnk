using Tnk.Core;
using Tnk.Core.UI;

namespace Tnk.Scenes.Menu
{
    internal class MainMenu
    {
        private Scene mainMenu;
        public readonly int sceneIndex = 0;
        public UIObject panelObj;
        public Panel panel;

        public MainMenu()
        {
            mainMenu = SceneManager.CreateScene("MainMenu");
            panelObj = new UIObject("Panel");
            panel = new Panel(panelObj);
            mainMenu.AddUIObject(panelObj);
        }
    }
}
