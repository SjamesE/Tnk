using SFML.System;

namespace Tnk
{
    internal class Time
    {
        private Clock clock;

        public float deltaTime { get; private set; }
        public float totalTime { get; private set; }

        private float lastTime = 0;

        Time()
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
