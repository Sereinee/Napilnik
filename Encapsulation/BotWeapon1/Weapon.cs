using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Weapon
    {
        private int damage;
        private int bullets;

        public int Damage
        {
            get { return damage; }
            set
            {
                if (value > 0)
                { damage = value; }
                else
                {
                    damage = 0;
                }
            }
        }

        public int Bullets
        {
            get { return bullets; }
            set
            {
                if (value >= 0)
                { bullets = value; }
                else
                {
                    bullets = 0;
                }
            }
        }

        public Weapon(int damage, int bullets)
        {
            Damage = damage;
            Bullets = bullets;
        }

        public void Fire(Player player, Bot botWithGun, int slotWeaponNumber, Weapon shootingWeapon)
        {
            Weapon weaponInUse = botWithGun.weaponSlots[slotWeaponNumber].weaponInSlot;
            if (bullets > 0 && weaponInUse == shootingWeapon)
            {
                player.Health -= damage;
                Bullets -= 1;
            }
            else
            {
                return;
            }
        }
    }
}