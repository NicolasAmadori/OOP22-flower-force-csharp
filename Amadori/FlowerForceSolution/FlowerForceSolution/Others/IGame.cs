namespace Others
{
    public interface IGame
    {
        /// <summary>
        /// Determine if the game has ended (true in that case).
        /// </summary>
        bool IsOver { get; }

        /// <summary>
        /// The result of the game: true if the player won the level.
        /// </summary>
        bool Result { get; }

        /// <summary>
        /// Call to update the game status.
        /// </summary>
        void Update();
    }
}
