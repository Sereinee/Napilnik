using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class WeaponSlot
    {
        private Weapon weaponInSlot;
        public Weapon WeaponInSlot {
            get;
            private set;
        }

        private bool weaponActive;
        public bool WeaponActive
        {
            get;
            private set;
        }

        public WeaponSlot(Weapon weapon, bool activateSlotWeapon = true)
        {
            WeaponActive = activateSlotWeapon;
            WeaponInSlot = weapon;
        }

    }
}
