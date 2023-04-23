using FlowerForceSolution;

namespace Others
{
    /// <summary>
    /// This is an implementation of <see cref="IWorld"/>.
    /// </summary>
    public class World : IWorld
    {
        /// <inheritdoc />
        public IPlayer Player { get; private set; }

        /// <summary>
        /// Generates a world.
        /// </summary>
        /// <param name="p">the player that plays the game</param>
        public World(IPlayer? p = null)
        {
            Player = p ?? new Player();
        }

        /// <inheritdoc />
        public IGame CreateAdventureModeGame(int levelId)
        {
            throw new NotImplementedException(); //Not implemented because it is not my part of the project.
        }

        /// <inheritdoc />
        public IGame CreateSurvivalModeGame()
        {
            throw new NotImplementedException(); //Not implemented because it is not my part of the project.
        }
    }
}
