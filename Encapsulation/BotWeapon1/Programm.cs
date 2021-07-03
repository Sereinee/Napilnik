using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    class Programm : MonoBehaviour
    {
        Player player;
        Bot bot;
        Weapon botWeapon1;
        Weapon botWeapon2;

        public void Start()
        {
            botWeapon1 = new Weapon(10, 10);
            botWeapon2 = new Weapon(20, 10);
            player = new Player(100);
            bot = new Bot(2, botWeapon1, botWeapon2);
            bot.BotFireFromSlot(player, bot, 0);
            Debug.Log(player.Health.ToString());
            bot.BotFireFromSlot(player, bot, 1);
            Debug.Log(player.Health.ToString());
        }
    }
}
