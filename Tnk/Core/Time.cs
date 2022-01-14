using SFML.System;

namespace Tnk.Core
{
    internal class Time
    {
        private Clock clock;

        public float deltaTime { get; private set; }
        public float totalTime { get; private set; }

        private float lastTime = 0;

        public Time()
        {
            clock = new Clock();
        }

        public void Update()
        {
            totalTime = clock.ElapsedTime.AsSeconds();
            deltaTime = totalTime - lastTime;


            lastTime = totalTime;
        }

    }
}
