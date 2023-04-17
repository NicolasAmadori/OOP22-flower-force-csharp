using System.Drawing;

namespace Others
{
    public static class YardInfo
    {
        public const int Rows = 5;
        public const int Cols = 9;
        private const float Height = 880f;
        private const float Width = 1314f;
        public static readonly SizeF Yard = new SizeF(Width, Height);
        public static readonly SizeF Cell = new SizeF(Width / Cols, Height / Rows);

        public static PointF GetEntityPosition(int row, int col)
            => new PointF((col + 1) * Cell.Width, (row + 1) * Cell.Height);

        public static PointF ToTopLeftCorner(PointF centre, int radius)
            => new PointF(centre.X - (radius + 1) * Cell.Width, centre.Y - (radius + 1) * Cell.Height);

        public static PointF ToBottomRightCorner(PointF centre, int radius)
            => new PointF(centre.X + radius * Cell.Width, centre.Y + radius * Cell.Height);
    }
}
