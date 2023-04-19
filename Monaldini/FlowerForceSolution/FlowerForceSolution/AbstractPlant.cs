using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerForce
{
    /// <summary>
    /// This abstract class implements some aspects common to all <see cref="IPlant"/> objects.
    /// </summary>
    public class AbstractPlant : AbstractLivingEntity, IPlant
    {
        /// <inheritdoc />
        public int Cost { get; }

        /// <inheritdoc />;
        public int RechargeTime { get; }

        /// <summary>
        /// </summary>
        /// <param name="pos">the initial position to place the entity in</param>
        /// <param name="timer">used to produce bullets/suns at the right time</param>
        /// <param name="health">the starting health of the entity</param>
        /// <param name="cost">plant's cost</param>
        /// <param name="rechargeTime">plant's recharge time</param>
        /// <param name="plantName">plant's name</param>
        public AbstractPlant(Tuple<double, double> pos, MyTimer timer, int health, int cost, int rechargeTime, string plantName) : base(pos, timer, health, plantName)
        {
            Cost = cost;
            RechargeTime = rechargeTime;
        }
    }
}
