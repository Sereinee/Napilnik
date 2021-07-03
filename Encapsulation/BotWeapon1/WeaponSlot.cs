using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napilnik1_1
{
    public class WeaponSlot
    {
        public Weapon weaponInSlot;
        public bool weaponEqualSlotWeapon;

        public WeaponSlot(Weapon weapon)
        {
            weaponInSlot = weapon;
        }

        public void FireFromSlot(Player player, Bot botWithGun, int slotWeaponNumber, Weapon shootingWeapon)
        {
            weaponInSlot.Fire(player, botWithGun, slotWeaponNumber, shootingWeapon);
        }
    }
}
