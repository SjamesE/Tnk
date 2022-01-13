using Tnk.Scenes.Menu;

namespace Tnk.Core
{
    internal class MainGame : Game
    {
        public override void Initialize()
        {
            MainMenu mainMenu = new MainMenu();
            SceneManager.ChangeActiveScene(mainMenu.sceneIndex);
        }

        public override void Update()
        {
            //throw new NotImplementedException();
        }
    }
}
