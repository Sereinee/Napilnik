using System;
using System.Collections.Generic;
using UnityEngine;

    class Programm: MonoBehaviour
{
    Player player;
    Bot bot;
    Weapon botWeapon;
    
    public void Start()
    {
        botWeapon = new Weapon(10, 10);
        player = new Player(100);
        bot = new Bot(2);
        bot.CreateSlot(0, botWeapon);
        bot.OnSeePlayer(player, 0);
        Debug.Log(player.Health.ToString());
    }
}
