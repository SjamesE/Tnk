using SFML.Graphics;
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

        public MainMenu(RenderWindow window)
        {
            mainMenu = SceneManager.CreateScene("MainMenu");
            panelObj = new UIObject(window, "Panel", new Vector2i(500, 100));
            panel = new Panel(panelObj);
            panel.SetBorderSize(2);
            panel.SetRounding(15);
            mainMenu.AddUIObject(panelObj);
        }
    }
}
