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
            panelObj = new UIObject(window, "Panel", new Vector2i(500, 550));
            panel = new Panel(panelObj);
            mainMenu.AddUIObject(panelObj);
        }
    }
}
