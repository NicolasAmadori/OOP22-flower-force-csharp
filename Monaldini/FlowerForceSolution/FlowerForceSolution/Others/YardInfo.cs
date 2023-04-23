using System.Drawing;

namespace Others
{
    /// <summary>
    /// Models the yard of the game, in which the entities are placed.
    /// </summary>
    public static class YardInfo
    {
        private const int Rows = 5;
        private const int Cols = 9;
        private const float Height = 880f;
        private const float Width = 1314f;

        /// <summary>
        /// The dimension of a single cell
        /// </summary>
        public static readonly SizeF Cell = new SizeF(Width / Cols, Height / Rows);
    }
}
