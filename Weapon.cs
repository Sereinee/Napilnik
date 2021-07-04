using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Weapon
    {
        private int _damage;
        private int _bullets;

        public Weapon(int damage, int bullets)
        {
            _damage = damage;
            _bullets = bullets;
        }

        public void Fire(Player player, WeaponSlot wepslot)
        {
            if (_bullets > 0 && wepslot.WeaponActive)
            {
                player.TakeDamage(_damage);
                _bullets -= 1;
            }
            else
                return;
        }
    }
}