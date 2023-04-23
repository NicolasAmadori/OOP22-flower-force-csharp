using Others;

namespace Flower_Force
{
    /// <summary>
    /// This is an implementation of <see cref="IController"/>.
    /// </summary>
    class Controller : IController
    {
        private IWorld _world;
        private IGame _game;

        /// <inheritdoc />
        public int PlayerCoins
        {
            get => _world.Player.Coins;
        }

        /// <inheritdoc />
        public int PlayerScoreRecord
        {
            get => _world.Player.ScoreRecord;
        }

        /// <inheritdoc />
        public int LastUnlockedLevel
        {
            get => _world.Player.LastUnlockedLevelId;
        }

        /// <summary>
        /// Create a new instance of Controller.
        /// </summary>
        public Controller()
        {
            _world = new World();
        }

        /// <inheritdoc />
        public void StartNewAdventureModeGame(int levelId)
        {
            _game = _world.CreateAdventureModeGame(levelId);
        }

        /// <inheritdoc />
        public void StartNewSurvivalModeGame()
        {
            _game = _world.CreateSurvivalModeGame();
        }
    }
}
