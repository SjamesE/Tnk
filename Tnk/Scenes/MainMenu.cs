using SFML.Graphics;
using Tnk.Core;
using Tnk.Core.UI;
using Tnk.Generics;

namespace Tnk.Scenes.Menu
{
    internal class MainMenu
    {
        private Scene mainMenu;
        private RenderWindow window;
        public readonly int sceneIndex = 0;
        public UIObject panelObj;
        public Panel panel;

        public MainMenu(RenderWindow window)
        {
            this.window = window;
            mainMenu = SceneManager.CreateScene("MainMenu");
            panelObj = new UIObject("Panel");
            panel = new Panel(panelObj, new Vector2i(50, 100));
            panel.SetPosition(10, 10);
            mainMenu.AddUIObject(panelObj);
        }
    }
}
