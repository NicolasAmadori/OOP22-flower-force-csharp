﻿using FlowerForce;

namespace Others
{
    public interface IZombie : IMovingEntity, ILivingEntity
    {
        void Freeze();

        void WarmUp();

        bool ManageEating(IPlant plant);

        int Difficulty { get; }
    }
}

