using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Player
    {
        private int _health;

        public Player(int health)
        {            
            if(health > 0)
            _health = health;
        }

        public void TakeDamage(int damage)
        {
            if (_health > 0)
                _health -= damage;
            else
                Debug.Log("Player is dead");
        }
    }
}
