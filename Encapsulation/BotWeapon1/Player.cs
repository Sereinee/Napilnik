using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Player
    {
        private int health;
        public int Health
        {
            get;
            private set;
        }

        public Player(int health)
        {
            if(health > 0)
                Health = health;
        }

        public void TakeDamage(int damage)
        {
            if (Health > 0)
                Health -= damage;
            else
                Debug.Log("Player is dead");
        }
    }
}