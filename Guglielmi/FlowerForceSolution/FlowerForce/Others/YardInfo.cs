using System.Drawing;

namespace Others
{
    /// <summary>
    /// Models the yard of the game, in which the entities are placed.
    /// </summary>
    public static class YardInfo
    {
        /// <summary>
        /// The rows of yard's
        /// </summary>
        public const int Rows = 5;

        /// <summary>
        /// The columns of yard's
        /// </summary>
        public const int Cols = 9;
        private const float Height = 880f;
        private const float Width = 1314f;

        /// <summary>
        /// The dimension of the entire yard
        /// </summary>
        public static readonly SizeF Yard = new SizeF(Width, Height);

        /// <summary>
        /// The dimension of a single cell
        /// </summary>
        public static readonly SizeF Cell = new SizeF(Width / Cols, Height / Rows);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"> of the cell </param>
        /// <param name="col"> of the cell </param>
        /// <returns> the lower right corner of the cell, where the entity will be placed </returns>
        public static PointF GetEntityPosition(int row, int col)
            => new PointF((col + 1) * Cell.Width, (row + 1) * Cell.Height);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="centre"> point, that is the bottom right corner of the central cell of the square </param>
        /// <param name="radius"> of the square, in number of cells </param>
        /// <returns> the top left corner of this square </returns>
        public static PointF ToTopLeftCorner(PointF centre, int radius)
            => new PointF(centre.X - (radius + 1) * Cell.Width, centre.Y - (radius + 1) * Cell.Height);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="centre"> point, that is the bottom right corner of the central cell of the square </param>
        /// <param name="radius"> of the square, in number of cells </param>
        /// <returns> the bottom right corner of this square </returns>
        public static PointF ToBottomRightCorner(PointF centre, int radius)
            => new PointF(centre.X + radius * Cell.Width, centre.Y + radius * Cell.Height);
    }
}
