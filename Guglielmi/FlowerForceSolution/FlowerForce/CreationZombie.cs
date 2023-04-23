using Others;
using System.Drawing;

namespace FlowerForce
{
    /// <summary>
    /// Implementation of <see cref="ICreationZombie"/>
    /// </summary>
    public class CreationZombie : ICreationZombie
    {
        private readonly int _zombieMaxDifficulty;
        private readonly List<Func<PointF, Zombie>> _zombies;
        private int _levelZombieToSpawn;
        private int _prevRow = -1;
        private readonly Random _rand = new Random();
        private readonly static PointF TemporaryPosition = new PointF(0, 0);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="zombies"> zombies the list of zombie type to spawn </param>
        public CreationZombie(List<Func<PointF, Zombie>> zombies)
        {
            _zombies = zombies;
            _zombieMaxDifficulty = zombies.Select(
                z => z(TemporaryPosition).Difficulty)
                    .DefaultIfEmpty()
                    .Max();
            _levelZombieToSpawn = zombies.Select(
                    z => z(TemporaryPosition).Difficulty)
                    .DefaultIfEmpty()
                    .Min();
        }

        /// <inheritdoc />
        public Zombie creationZombie(int delta)
        {
            var zombieToSpawn = _zombies.Where(
                z => z(TemporaryPosition).Difficulty <= _levelZombieToSpawn).ToHashSet();
            int randomValue = _rand.Next(zombieToSpawn.Select(
                z => _zombieMaxDifficulty - z(TemporaryPosition).Difficulty + delta)
                .Sum() + 1);
            int row;
            do
            {
                row = _rand.Next(YardInfo.Rows);
            } while (row == _prevRow);

            foreach (var z in zombieToSpawn)
            {
                randomValue = randomValue - (_zombieMaxDifficulty + delta -
                    z(TemporaryPosition).Difficulty);
                if (randomValue <= 0)
                {
                    return z(YardInfo.GetEntityPosition(row, YardInfo.Cols - 1));
                }
            }
            return (Zombie)ZombieFactory.Basic(YardInfo.GetEntityPosition(row, YardInfo.Cols - 1));
        }

        /// <inheritdoc />
        public void increaseLevelZombieToSpawn()
        {
            if (_levelZombieToSpawn < _zombieMaxDifficulty)
            {
                _levelZombieToSpawn += _levelZombieToSpawn;
            }
        }
    }
}
