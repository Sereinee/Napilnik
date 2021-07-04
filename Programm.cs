using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Napilnik1_1
{
    class Programm : MonoBehaviour
    {
        public void Start()
        {
            var weapon = new Weapon(10,10);
            var bot = new Bot(weapon);
            var player = new Player(100);
            bot.FireFromSlot(player, bot.weaponSlot);
            Debug.Log(player._health.ToString());
        }
    }
}
