﻿using System;

namespace Enemies
{
    /// <summary>
    /// public class Zombie, defines a zombie.
    /// </summary>
    class Zombie
    {
        /// <summary>
        /// Health of the zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// public constructor Zombie, health of zombie.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// public constructor Zombie
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}
