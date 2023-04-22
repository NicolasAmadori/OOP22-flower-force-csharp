using System;
using System.Collections.Generic;

namespace Flower_Force
{
    /// <summary>
    /// This is an implementation of <see cref="Player"/>.
    /// </summary>
    public class Player : IPlayer
    {

        private ISet<int> _plantIds;
        /// <inheritdoc />
        public int Coins { get; private set; }

        /// <inheritdoc />
        public int ScoreRecord { get; private set; }

        /// <inheritdoc />
        public int LastUnlockedLevelId { get; private set; }

        /// <inheritdoc />
        public ISet<int> PlantsIds {
            get
            {
                return new HashSet<int>(_plantIds);
            }

            private set
            {
                _plantIds = value;
            }
        }

        /// <summary>
        /// Constructor to instantiate a totally new player.
        /// </summary>
        public Player() : this(0,0,1) { }

        /// <summary>
        /// Constructor to instantiate an existing player (probably loaded from a saving file), with given values.
        /// </summary>
        /// <param name="nCoins">The integer representing the number of coins the player has</param>
        /// <param name="scoreRecord">The integer representing the score record of the player</param>
        /// <param name="lastUnlockedLevelId">The integer representing the id of the last level the player has unlocked</param>
        public Player(int nCoins, int scoreRecord, int lastUnlockedLevelId) : this(nCoins, scoreRecord, lastUnlockedLevelId, null) { }

        /// <summary>
        /// Instantiate a copy of an existing Player instance.
        /// </summary>
        /// <param name="p">The player instance to copy</param>
        public Player(IPlayer p) : this(p.Coins, p.ScoreRecord, p.LastUnlockedLevelId, p.PlantsIds) { }

        /// <summary>
        /// Constructor that get all the private information to create a copy of an instance.
        /// </summary>
        /// <param name="nCoins">The number of coins the player will have.</param>
        /// <param name="scoreRecord">The score record the player will have.</param>
        /// <param name="lastUnlockedLevelId">The id of the last level the player will unlock.</param>
        /// <param name="plantsIds">The set of plants ids the player will have in his inventory.</param>
        private Player(int nCoins, int scoreRecord, int lastUnlockedLevelId, ISet<int> plantsIds = null)
        {
            Coins = nCoins;
            ScoreRecord = scoreRecord;
            LastUnlockedLevelId = lastUnlockedLevelId;
            PlantsIds = plantsIds != null ? plantsIds : new HashSet<int>();
        }

        /// <inheritdoc />
        public void IPlayer.AddCoins(int nCoins)
        {
            if (nCoins < 0)
            {
                throw new ArgumentException("nCoins must be a positive number.");
            }
            Coins += nCoins;
        }

        /// <inheritdoc />
        public void IPlayer.AddNewScore(int score)
        {
            if (score < 0)
            {
                throw new ArgumentException("score must be a positive number.");
            }
            ScoreRecord = Math.Max(ScoreRecord, score);
        }

        /// <inheritdoc />
        public void IPlayer.AddPlant(int plantIndex)
        {
            if (plantIndex < 0)
            {
                throw new ArgumentException("plantIndex must be a positive number.");
            }
            PlantsIds.Add(plantIndex);
        }

        /// <inheritdoc />
        public bool IPlayer.SubtractCoins(int nCoins)
        {
            if(nCoins < 0)
            {
                throw new ArgumentException("nCoins must be a positive number.");
            }

            if (nCoins > Coins)
            {
                return false;
            }
            Coins -= nCoins;
            return true;
        }

        /// <inheritdoc />
        public void IPlayer.UnlockedNextLevel() => LastUnlockedLevelId++;
    }
}
