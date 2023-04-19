using System.Drawing;

namespace Others
{
    public static class YardInfo
    {
        public const int Rows = 5;
        public const int Cols = 9;
        private const float Height = 880f;
        private const float Width = 1314f;
        public static readonly SizeF Cell = new SizeF(Width / Cols, Height / Rows);
    }
}
