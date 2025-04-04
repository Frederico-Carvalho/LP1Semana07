using System;

namespace MyRPG
{
    class Player
    {
        private int xp;
        private float health;
        public string Name { get; }

        public int XP
        {
            get => xp;
            set
            {
                if (value > 0)
                {
                    xp += value;
                }
            }
        }

        public int Level
        {
            get
            {
                return (int)1 + xp / 1000;
            }
        }

        public float Health
        {
            get
            {
                return Math.Clamp(health, 0, MaxHealth);
            }
            set
            {
                health = Math.Clamp(value, 0, MaxHealth); ;
            }
        }

        public float MaxHealth
        {
            get
            {
                return (float)100 + (Level - 1) * 20;
            }
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
            XP = (int)damage / 20;
        }

        public Player(string name)
        {
            Name = name;
            xp = 0;
            Health = MaxHealth;
        }
    }
}