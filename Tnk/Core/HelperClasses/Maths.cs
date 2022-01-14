namespace Tnk.Core.Math
{
    internal static class Maths
    {
        public static float Normalize(float value, float min, float max, float multiplier = 1)
        => ((value - min) / max) * multiplier;

        public static int Normalize(int value, int min, int max, int multiplier = 1)
        => (int)((float)(value - min) / max * multiplier);

        public static byte Normalize(byte value, byte min, byte max, byte multiplier = 1)
        => (byte)((float)(value - min) / max * multiplier);
    }
}
