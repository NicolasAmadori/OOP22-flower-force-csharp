namespace FlowerForce
{
    /// <summary>
    /// This utility class contains the possible plant's recharge times in the game.
    /// </summary>
    public static class RechargeTimes
    {
        /// <summary>
        /// A fast plant's recharge time
        /// </summary>
        public static int FastRechargeTime
        {
            get => RenderingInformation.ConvertSecondsToCycles(7.5);
        }

        /// <summary>
        /// A slow plant's recharge time
        /// </summary>
        public static int SlowRechargeTime
        {
            get => RenderingInformation.ConvertSecondsToCycles(30);
        }

        /// <summary>
        /// A very slow plant's recharge time
        /// </summary>
        public static int VerySlowRechargeTime
        {
            get => RenderingInformation.ConvertSecondsToCycles(50);
        }
    }
}
