using Tnk.Core;
using Tnk.Core.UI;
using Tnk.Generics;

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
            panel = new Panel(panelObj, new Vector2i(600, 800));
            mainMenu.AddUIObject(panelObj);
        }
    }
}
