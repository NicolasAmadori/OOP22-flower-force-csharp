using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Force
{
    /// <summary>
    /// The class representing the player with all his information.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// The number of coins the player has.
        /// </summary>
        int Coins { get; }

        /// <summary>
        /// The score record of the player.
        /// </summary>
        int ScoreRecord { get; }

        /// <summary>
        /// The id of the last level the player has unlocked.
        /// </summary>
        int LastUnlockedLevelId { get; }

        /// <summary>
        /// All the bought plant ids.
        /// </summary>
        ISet<int> PlantsIds { get; }

        /// <summary>
        /// Increment the number of coins the player has.
        /// </summary>
        /// <param name="nCoins">The number of coins to add to the total</param>
        void AddCoins(int nCoins);

        /// <summary>
        /// Decrement the number of coins the player has.
        /// </summary>
        /// <param name="nCoins">The number of coins to subtract from the total</param>
        /// <returns>True if the operation has been successful, false otherwise</returns>
        bool SubtractCoins(int nCoins);

        /// <summary>
        /// Set a new value for the score record of the player.
        /// </summary>
        /// <param name="score">The integer representing the new score record</param>
        void AddNewScore(int score);

        /// <summary>
        /// Unlock the next level.
        /// </summary>
        void UnlockedNextLevel();

        /// <summary>
        /// Add a plant in player inventory.
        /// </summary>
        /// <param name="plantIndex">The index of the plant to add</param>
        void AddPlant(int plantIndex);
    }
}
