using Flower_Force;

namespace Others
{
    /// <summary>
    /// Models the world the game's played in.
    /// </summary>
    public interface IWorld
    {
        /// <summary>
        /// The player that is playing the game.
        /// </summary>
        IPlayer Player { get; }

        /// <summary>
        /// Creates an Adventure Mode game.
        /// </summary>
        /// <param name="levelId">the level to create</param>
        /// <returns>the game to be played</returns>
        IGame CreateAdventureModeGame(int levelId);

        /// <summary>
        /// Creates a Survival Mode game.
        /// </summary>
        /// <returns>the game to be played</returns>
        IGame CreateSurvivalModeGame();
    }
}
