﻿using System.Drawing;
using Others;

namespace FlowerForceZombie
{
    public abstract class AbstractLivingEntity : AbstractEntity, ILivingEntity
    {
        public int Health { get; private set; }
        protected MyTimer Timer { get; }

        protected AbstractLivingEntity(PointF position, MyTimer timer, int health, string name) : base(position, name)
        {
            Health = health;
            Timer = timer;
        }
        public virtual void ReceiveDamage(int damage)
        {
            Health -= damage;
            Over = Health <= 0;
        }
        public virtual void UpdateState() => Timer.UpdateState();
    }
}