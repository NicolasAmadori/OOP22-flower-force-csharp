using Others;

namespace TestFlowerForce
{
    
    [TestClass]
    public class TestZombieGeneration
    {
        ZombieGenerationLevel _zombieGen =
            new ZombieGenerationLevel(1);
        
        private ZombieGenerationInfinite _zombieGenInfinite 
            = new ZombieGenerationInfinite(1);
        private const double StandardSecsSpawnZombie = 15.0;
        private const int FirstZombieHorde = 12;
        private const int SecondZombieHorde = 17;
        private static readonly int TimeToSpawnZombie = (int)
            StandardSecsSpawnZombie * RenderingInformation.FramesPerSecond;

        /// <summary>
        /// Sets up testing.
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            _zombieGen = new ZombieGenerationLevel(1);
            _zombieGenInfinite = new ZombieGenerationInfinite(1);
        }

        /// <summary>
        /// Test the zombie generation.
        /// </summary>
        [TestMethod]
        public void ZombieGenerationTest()
        {
            //at the beginning there will be 0 zombie spawned
            Assert.AreEqual(0, _zombieGen.SpawnedZombie);

            for (int i = 0; i < TimeToSpawnZombie; i++)
            {
                _zombieGen.ZombieGeneration();
            }
            //after waiting this amount of time, total spawned zombies will be 1
            Assert.AreEqual(1, _zombieGen.SpawnedZombie);

            for (int i = 0; i < TimeToSpawnZombie; i++)
            {
                _zombieGen.ZombieGeneration();
            }
            //after waiting this amount of time, total spawned zombies will be 2
            Assert.AreEqual(2, _zombieGen.SpawnedZombie);
        }

        /// <summary>
        /// Test the increase in the number of horde zombies.
        /// </summary>
        [TestMethod]
        public void testIncreaseHorde()
        {
            //the first wave of zombies consists of 8 zombies + 5 horde zombies
            Assert.AreEqual(FirstZombieHorde, _zombieGenInfinite.NumberHordeZombie);

            while (_zombieGenInfinite.SpawnedZombie != FirstZombieHorde)
            {
                _zombieGenInfinite.ZombieGeneration();
            }

            //the second wave of zombies consists of 8 zombies + 10 horde zombies,
            //because the horde increases by 5
            Assert.AreEqual(SecondZombieHorde, _zombieGenInfinite.NumberHordeZombie);
        }
    }
}