using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Bot : MonoBehaviour
    {
        private WeaponSlot weaponSlot;

        public WeaponSlot WeaponSlot
        {
            get;
            private set;
        }

        public Bot(Weapon weapon)
        {
            WeaponSlot = new WeaponSlot(weapon);
        }

        public void FireFromSlot(Player player, WeaponSlot weaponSlot)
        {
            weaponSlot.WeaponInSlot.Fire(player, weaponSlot);
        }
    }
}
