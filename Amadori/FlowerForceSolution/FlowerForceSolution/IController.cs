namespace FlowerForceSolution
{
    /// <summary>
    /// This is the class that connects the view and the model sides, making them communicate.
    /// </summary>
    public interface IController
    {
        /// <summary>
        /// Get the number of coins the player has.
        /// </summary>
        int PlayerCoins { get; }

        /// <summary>
        /// Get the score record the player has obtained.
        /// </summary>
        int PlayerScoreRecord { get; }

        /// <summary>
        /// Get the id of the last level the player has unlocked.
        /// </summary>
        int LastUnlockedLevel { get; }

        /// <summary>
        /// Start a new game for a specified level.
        /// </summary>
        /// <param name="levelId">The id of the level to play</param>
        void StartNewAdventureModeGame(int levelId);

        /// <summary>
        /// Start a new game in survival mode.
        /// </summary>
        void StartNewSurvivalModeGame();
    }
}
