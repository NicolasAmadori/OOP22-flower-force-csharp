using System.Diagnostics;
using Others;

namespace FlowerForceSolution
{
    public class GameLoop : IGameLoop
    {
        private const long SECOND_IN_MILLISECOND = 1_000_000_000;
        private readonly IGameEngine _gameEngine;
        private readonly IGame _model;
        private readonly long _timeSlice;
        private long _lastUpdateTime;
        private long _timeAccumulator;
        private bool _updated = false;
        private bool _running = true;
        private Stopwatch _stopwatch;

        /// <summary>
        /// Instantiate a new GameLoop giving it the model and the GameEngine it will communicate with.
        /// </summary>
        /// <param name="gameEngine">The gameEngine to render on the view</param>
        /// <param name="model">The GameModel to get the game information</param>
        /// <param name="framesPerSecond">The frame rate the game must be run</param>
        public GameLoop(IGameEngine gameEngine, IGame model, int framesPerSecond)
        {
            _gameEngine = gameEngine;
            _model = model;
            _timeSlice = SECOND_IN_MILLISECOND / framesPerSecond;
            _stopwatch = Stopwatch.StartNew();
            _lastUpdateTime = getCurrentNanoseconds();
        }

        /// <inheritdoc />
        public void Run()
        {
            if (_running)
            {
                if (!_model.IsOver)
                {
                    long elapsedTime = getCurrentNanoseconds() - _lastUpdateTime;

                    _lastUpdateTime += elapsedTime;
                    _timeAccumulator += elapsedTime;

                    while (_timeAccumulator > _timeSlice)
                    {
                        _model.Update();
                        _updated = true;
                        _timeAccumulator -= _timeSlice;
                    }

                    if (_updated)
                    {
                        _gameEngine.Render();
                        _updated = false;
                    }
                }
                else
                {
                    _gameEngine.Over(_model.Result);
                    _running = false;
                }
            }
        }

        private long getCurrentNanoseconds() => _stopwatch.ElapsedMilliseconds * 1_000_000L;
    }
}
