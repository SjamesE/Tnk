using SFML.System;

namespace Tnk.Core
{
    internal static class Time
    {
        private static Clock clock;

        public static readonly float fixedDeltaTime = 1f/60;

        public static float deltaTime { get; private set; }
        public static float totalTime { get; private set; }

        private static float lastTime = 0;

        static Time()
        {
            clock = new Clock();
        }

        public static void Update()
        {
            totalTime = clock.ElapsedTime.AsSeconds();
            deltaTime = totalTime - lastTime;
            //Console.WriteLine(deltaTime.ToString());

            lastTime = totalTime;
        }
    }
}
