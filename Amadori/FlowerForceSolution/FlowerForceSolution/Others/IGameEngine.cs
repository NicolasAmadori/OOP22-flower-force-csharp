namespace Others
{
    /// <summary>
    /// This is the class that represent the graphic engine of the game.
    /// </summary>
    public interface IGameEngine
    {
        /// <summary>
        /// This method can be called to refresh the view.
        /// </summary>
        void Render();

        /// <summary>
        /// This method can be called to show the outcome of the game.
        /// </summary>
        /// <param name="result">True if the game is won, false otherwise</param>
        void Over(bool result);
    }
}
