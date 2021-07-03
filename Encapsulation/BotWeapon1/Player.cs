using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Player
    {
        private int health;

        public Player(int health)
        {
            Health = health;
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (value > 0)
                { health = value; }
            }
        }
    }
}