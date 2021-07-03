using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot
{
    private Weapon[] botWeaponSlots;

    public Bot(int slots)
    {
        botWeaponSlots = new Weapon[slots];
    }

    public void CreateSlot(int slotNumber, Weapon weapon)
    {
        if(slotNumber >= 0 && slotNumber < 2)
        botWeaponSlots[slotNumber] = weapon;
    }

    public void OnSeePlayer(Player player, int weaponSlot)
    {
        botWeaponSlots[weaponSlot].Fire(player);
    }
}