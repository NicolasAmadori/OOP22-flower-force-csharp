namespace FlowerForce
{
    /// <summary>
    /// Models a <see cref="IPlant"/> that shoots bullets.
    /// </summary>
    public interface IShootingPlant : IPlant
    {
        /// <summary>
        /// Represents next bullet to be shot (if it's been already produced).
        /// </summary>
        IBullet? NextBullet { get; }
    }
}
