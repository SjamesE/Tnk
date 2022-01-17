using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace Tnk.Core
{
    internal abstract class Game
    {
        static readonly int TARGET_FPS = 60;
        static readonly float FRAME_TIME = 1f / TARGET_FPS;

        uint WINDOW_HEIGHT = 600;
        uint WINDOW_WIDTH = 800;

        RenderWindow window;
        protected Render renderer;

        public Game()
        {
            window = new RenderWindow(new VideoMode(WINDOW_WIDTH, WINDOW_HEIGHT), " ");
            renderer = new Render(window);
            window.Closed += Window_Closed;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            window.Close();
        }

        public void Run()
        {
            float timeTillUpdate = FRAME_TIME;
            Initialize(window);
            while(window.IsOpen)
            {
                window.DispatchEvents();
                //Console.WriteLine("2  " + Time.deltaTime);
                Time.Update();
                Update();
                if (timeTillUpdate < 0)
                {
                    timeTillUpdate = FRAME_TIME;
                    
                    renderer.Draw(SceneManager.GetActiveScene());
                }
                else timeTillUpdate -= Time.deltaTime;
            }
        }

        public abstract void Initialize(RenderWindow window);

        public abstract void Update();
    }
}
