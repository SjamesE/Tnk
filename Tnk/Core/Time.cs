using SFML.System;

namespace Tnk.Core
{
    internal class Time
    {
        private Clock clock;

        public float DeltaTime { get; private set; }
        public float TotalTime { get; private set; }

        private float lastTime = 0;

        public Time()
        {
            clock = new Clock();
        }

        public void Update()
        {
            TotalTime = clock.ElapsedTime.AsSeconds();
            DeltaTime = TotalTime - lastTime;


            lastTime = TotalTime;
        }

    }
}
