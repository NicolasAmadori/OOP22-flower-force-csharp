using Flower_Force;

namespace Others
{
    public class World : IWorld
    {
        /// <inheritdoc />
        public IPlayer Player { get; private set; }

        /// <summary>
        /// Generates a world.
        /// </summary>
        /// <param name="p">the player that plays the game</param>
        public World(IPlayer p = null)
        {
            Player = p != null ? p : new Player();
        }

        /// <inheritdoc />
        public IGame CreateAdventureModeGame(int levelId)
        {
            throw new System.NotImplementedException(); //Not implemented because it is not my part of the project.
        }

        /// <inheritdoc />
        public IGame CreateSurvivalModeGame()
        {
            throw new System.NotImplementedException(); //Not implemented because it is not my part of the project.
        }
    }
}
