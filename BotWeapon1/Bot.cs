using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Bot : MonoBehaviour
    {
        private WeaponSlot weaponSlot;

        public Bot(Weapon weapon)
        {
            weaponSlot = new WeaponSlot(weapon);
        }

        public void FireFromSlot(Player player)
        {
            weaponSlot.WeaponInSlot.Fire(player);
        }
    }
}