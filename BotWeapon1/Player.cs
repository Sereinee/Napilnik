using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Player
    {
        public int _health;

        public Player(int health)
        {
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