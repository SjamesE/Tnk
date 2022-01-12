using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace Tnk
{
    internal abstract class Game
    {
        static readonly int TARGET_FPS = 60;
        static readonly float FRAME_TIME = 1f / TARGET_FPS;

        uint WINDOW_HEIGHT = 600;
        uint WINDOW_WIDTH = 800;

        Window window;
        protected Time time;

        public Game()
        {
            window = new Window(new VideoMode(WINDOW_WIDTH, WINDOW_HEIGHT), "Tanks");
            time = new Time();
        }
        
        public void Run()
        {
            float timeTillUpdate = FRAME_TIME;
            while(window.IsOpen)
            {
                time.Update();
                if (timeTillUpdate < 0)
                {
                    timeTillUpdate = FRAME_TIME;
                    Console.WriteLine(time.totalTime.ToString());
                    Update();
                    Draw();
                }
                else timeTillUpdate -= time.deltaTime;
            }
        }


        public abstract void Update();
        public abstract void Draw();
    }
}
