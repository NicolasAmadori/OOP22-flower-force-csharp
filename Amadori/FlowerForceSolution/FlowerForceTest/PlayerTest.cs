namespace Flower_Force_Test
{
    /// <summary>
    /// Test for class <see cref="Player"/>.
    /// </summary>
    [TestClass]
    class PlayerTest
    {
        private const int STARTING_COINS = 0;
        private const int FIRST_SCORE_TO_ADD = 4_000;
        private const int SECOND_SCORE_TO_ADD = 1_500;
        private const int THIRD_SCORE_TO_ADD = 10_000;

        private IPlayer? _player;

        /// <summary>
        /// Sets up the testing.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            _player = new Player();
        }

        /// <summary>
        /// Test the <see cref="IPlayer.Coins"/>.
        /// </summary>
        [TestMethod]
        public void TestCoins()
        {
            Assert.IsNotNull(_player);
            int playerCoins = STARTING_COINS;
            //at first the player coins must be 0
            Assert.AreEqual(playerCoins, _player.Coins);

            //you should add 100 coins with no problem
            _player.AddCoins(100);
            playerCoins += 100;
            Assert.AreEqual(playerCoins, _player.Coins);

            //you should subtract 50 from 100 with no problem
            Assert.IsTrue(_player.SubtractCoins(50));
            playerCoins -= 50;
            Assert.AreEqual(playerCoins, _player.Coins);

            //you shouldn't be able to subtract 70 from 50 remaining coins
            Assert.IsFalse(_player.SubtractCoins(70));
            Assert.AreEqual(playerCoins, _player.Coins);
        }

        /// <summary>
        /// Test the <see cref="IPlayer.ScoreRecord"/>.
        /// </summary>
        [TestMethod]
        public void TestScore()
        {
            Assert.IsNotNull(_player);
            int playerScoreRecord = 0;
            //The initial score record must be 0
            Assert.AreEqual(playerScoreRecord, _player.ScoreRecord);

            //Adding a score of 4000, 4000 must be the new score record
            _player.AddNewScore(FIRST_SCORE_TO_ADD);
            playerScoreRecord = Math.Max(playerScoreRecord, FIRST_SCORE_TO_ADD);
            Assert.AreEqual(playerScoreRecord, _player.ScoreRecord);

            //adding a score of 1500, 4000 must still be the score record
            _player.AddNewScore(SECOND_SCORE_TO_ADD);
            playerScoreRecord = Math.Max(playerScoreRecord, SECOND_SCORE_TO_ADD);
            Assert.AreEqual(playerScoreRecord, _player.ScoreRecord);

            //adding a score of 10000, 10000 must be the new score record
            _player.AddNewScore(THIRD_SCORE_TO_ADD);
            playerScoreRecord = Math.Max(playerScoreRecord, THIRD_SCORE_TO_ADD);
            Assert.AreEqual(playerScoreRecord, _player.ScoreRecord);
        }
    }
}
