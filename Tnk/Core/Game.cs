﻿using SFML.System;
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
        protected Time time;
        protected Render renderer;

        public Game()
        {
            window = new RenderWindow(new VideoMode(WINDOW_WIDTH, WINDOW_HEIGHT), "Tanks");
            time = new Time();
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
            Initialize();
            while(window.IsOpen)
            {
                window.DispatchEvents();
                time.Update();
                if (timeTillUpdate < 0)
                {
                    timeTillUpdate = FRAME_TIME;
                    Console.WriteLine(time.TotalTime.ToString());
                    Update();
                    renderer.Draw(SceneManager.GetActiveScene());
                }
                else timeTillUpdate -= time.DeltaTime;
            }
        }

        public abstract void Initialize();

        public abstract void Update();
    }
}
