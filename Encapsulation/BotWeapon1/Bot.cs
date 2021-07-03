using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    public class Bot : MonoBehaviour
    {
        public WeaponSlot[] weaponSlots;
        public Bot(int slotNumber, Weapon weapon1, Weapon weapon2)
        {
            weaponSlots = new WeaponSlot[slotNumber];
            weaponSlots[0] = new WeaponSlot(weapon1);
            weaponSlots[1] = new WeaponSlot(weapon2);
        }

        public void BotFireFromSlot(Player player, Bot botWithGun, int slotWeaponNumber)
        {
            WeaponSlot weaponSlotInUse = weaponSlots[slotWeaponNumber];
            Weapon weaponInUse = weaponSlots[slotWeaponNumber].weaponInSlot;
            weaponSlotInUse.FireFromSlot(player, botWithGun, slotWeaponNumber, weaponInUse);
        }
    }
}