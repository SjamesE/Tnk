using SFML.Graphics;
using Tnk.Scenes.Menu;

namespace Tnk.Core
{
    internal class MainGame : Game
    {
        public override void Initialize(RenderWindow window)
        {
            MainMenu mainMenu = new MainMenu(window);
            SceneManager.ChangeActiveScene(mainMenu.sceneIndex);
        }

        public override void Update()
        {
            //throw new NotImplementedException();
        }
    }
}
