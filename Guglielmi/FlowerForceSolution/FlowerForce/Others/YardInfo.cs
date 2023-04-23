using System.Drawing;

namespace Others
{
    /// <summary>
    /// Models the yard of the game, in which the entities are placed.
    /// </summary>
    public static class YardInfo
    {
        private const float Height = 880f;
        private const float Width = 1314f;
        /// <summary>
        /// The rows of yard's
        /// </summary>
        public const int Rows = 5;

        /// <summary>
        /// The columns of yard's
        /// </summary>
        public const int Cols = 9;

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
    }
}
