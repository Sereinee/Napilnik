using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class WeaponSlot
    {
        public Weapon weaponInSlot;
        public Weapon WeaponInSlot{
            get;
            private set;
        }


        public WeaponSlot(Weapon weapon)
        {
            WeaponInSlot = weapon;
        }


    }
}
