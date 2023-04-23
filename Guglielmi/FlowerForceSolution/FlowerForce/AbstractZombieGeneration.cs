using Others;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlowerForce
{
    /// <summary>
    /// This is an implementation of <see cref="IZombieGeneration"/>
    /// </summary>
    public abstract class AbstractZombieGeneration : IZombieGeneration
    {
        private const double MinSecsSpawnZombie = 5.0;
        private const double MaxSecsSpawnZombie = 15.0;
        private const double StandardSecsSpawnZombieInHorde = 1.0;
        private const double StandardSecsDecSpawnZombieInHorde = 3.0;
        private static readonly int MinTimeToSpawnZombie = 
             RenderingInformation.ConvertSecondsToCycles(MinSecsSpawnZombie);
        private static readonly int StartTimeToSpawnZombie =
             RenderingInformation.ConvertSecondsToCycles(MaxSecsSpawnZombie);
        private static readonly int TimeToSpawnHordeZombie =
             RenderingInformation.ConvertSecondsToCycles(StandardSecsSpawnZombieInHorde);
        private static readonly int DecTimeZombie =
             RenderingInformation.ConvertSecondsToCycles(StandardSecsDecSpawnZombieInHorde);
        
        private ITimer _zombieTimer;
        private int _timeZombie = StartTimeToSpawnZombie;
        private readonly CreationZombie _genZombie;
        private readonly int _startNumberZombieHorde; 
        private readonly int _zombieBeforeHorde;
        private bool _incrementableHorde;
        private int _generatedZombie;
        private int _hordeGeneratedZombie;
        private int _hordeZombie;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="levelId"> of the level started </param>
        /// <param name="zombieBeforeHorde"> number of zombies to spawn before the horde </param>
        /// <param name="startNumberZombieHorde"> number of zombies in the starting horde </param>
        public AbstractZombieGeneration(int levelId, int zombieBeforeHorde,
            int startNumberZombieHorde)
        {
            _genZombie = new CreationZombie(LevelInfo.GetZombiesInfo(levelId));
            _zombieBeforeHorde = zombieBeforeHorde;
            _zombieTimer = new MyTimer(_timeZombie);
            _startNumberZombieHorde = startNumberZombieHorde;
            _hordeZombie = startNumberZombieHorde;
        }
        /// <inheritdoc />
        public int GetNumberHordeZombie() => _hordeZombie + _zombieBeforeHorde;

        /// <inheritdoc />
        public int GetSpawnedZombie() => _generatedZombie + _hordeGeneratedZombie;

        /// <inheritdoc />
        public virtual Zombie? ZombieGeneration()
        {
            _zombieTimer.UpdateState();
            if (_zombieTimer.Ready)
            {
                if (_generatedZombie == _zombieBeforeHorde)
                {
                    _hordeGeneratedZombie++;
                    if (_hordeGeneratedZombie == _hordeZombie)
                    {
                        if (_timeZombie - DecTimeZombie > MinTimeToSpawnZombie)
                        {
                            _timeZombie -= DecTimeZombie;
                        }
                        _zombieTimer.SetNumCycles(_timeZombie);
                        _incrementableHorde = true;
                        _generatedZombie = 0;
                        _hordeGeneratedZombie = 0;
                        _genZombie.increaseLevelZombieToSpawn();
                    }
                    else
                    {
                        _zombieTimer.SetNumCycles(TimeToSpawnHordeZombie);
                    }
                }
                else
                {
                    _generatedZombie++;
                }
                return _genZombie.creationZombie(_hordeZombie / _startNumberZombieHorde);
            }
            return null;
        }

        /// <summary>
        /// called if you want to increase the number of zombies in the horde.
        /// </summary>
        /// <param name="value"> used to increase the number of zombies in the horde </param>
        /// <param name="maxRange"> used to check that the number of zombies in the 
        /// horde does not exceed a certain value</param>
        protected void IncreaseHordeZombie(int value, int maxRange)
        {
            if (_incrementableHorde && _hordeZombie + value < maxRange)
            {
                _hordeZombie += value;
                _incrementableHorde = false;
            }
        }
    }
}
