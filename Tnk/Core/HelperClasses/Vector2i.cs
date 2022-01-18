namespace Tnk.Generics
{
    internal struct Vector2i
    {
        public static readonly Vector2 zero = new Vector2(0, 0);
        public static readonly Vector2 one = new Vector2(1, 1);
        public int x { get; set; }
        public int y { get; set; }

        public Vector2i()
        {
            x = 0;
            y = 0;
        }

        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector2i operator +(Vector2i left) => left;

        public static Vector2i operator -(Vector2i left) => new Vector2i(-left.x, -left.y);

        public static Vector2i operator +(Vector2i left, Vector2i right)
        {
            return new Vector2i(left.x + right.x, left.y + right.y);
        }

        public static Vector2i operator -(Vector2i left, Vector2i right)
        {
            return new Vector2i(left.x - right.x, left.y - right.y);
        }

        public static Vector2i operator *(Vector2i left, Vector2i right)
        {
            return new Vector2i(left.x * right.x, left.y * right.y);
        }

        public static Vector2i operator *(Vector2i left, int right)
        {
            return new Vector2i(left.x * right, left.y * right);
        }

        public static Vector2i operator /(Vector2i left, Vector2i right)
        {
            if (right.x == 0 || right.y == 0)
            {
                throw new DivideByZeroException();
            }
            return new Vector2i(left.x / right.x, left.y / right.y);
        }

        public static Vector2i operator /(Vector2i left, int right)
        {
            return new Vector2i(left.x / right, left.y / right);
        }

        public override string ToString() => $"X: {x}, Y: {y}";
    }
}
