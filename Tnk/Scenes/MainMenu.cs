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
        public UIObject buttonObj;
        public UIObject buttonObj1;
        public UIObject buttonObj2;
        public UIObject buttonObj3;
        public Button button;
        public Button button1;
        public Button button2;
        public Button button3;

        public MainMenu(RenderWindow window)
        {
            mainMenu = SceneManager.CreateScene("MainMenu");
            buttonObj = new UIObject(window, "Panel", new Vector2i(500, 100));
            button = new Button(buttonObj);
            button.SetBorderSize(3);
            button.SetRounding(20);
            button.SetFontSize(80);

            buttonObj1 = new UIObject(window, "Panel",new Vector2i(250, 370), new Vector2i(300, 80));
            button1 = new Button(buttonObj1);
            button1.SetBorderSize(7);
            button1.SetFontSize(50);

            buttonObj2 = new UIObject(window, "Panel", new Vector2i(300, 475), new Vector2i(200, 70));
            button2 = new Button(buttonObj2);
            button2.SetRounding(45);
            button2.SetBorderSize(0);
            button2.SetDisplayString("Dis smol Button");

            buttonObj3 = new UIObject(window, "Panel", new Vector2i(300, 100), new Vector2i(200, 70));
            button3 = new Button(buttonObj3);
            button3.SetFontSize(140);
            button3.SetColor(Color.Black);
            button3.SetFontColor(Color.White);
            button3.SetDisplayString("This is some text");


            mainMenu.AddUIObject(buttonObj);
            mainMenu.AddUIObject(buttonObj1);
            mainMenu.AddUIObject(buttonObj2);
            mainMenu.AddUIObject(buttonObj3);
        }
    }
}
