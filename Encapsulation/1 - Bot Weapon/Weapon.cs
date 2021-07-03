using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    private int damage;
    private int bullets;

    public int Damage
    {
        get { return damage; }
        set {
            if (value > 0)
            { damage = value; }
            else
            {
                damage = 0;
            }
        }
    }

    public int Bullets
    {
        get { return bullets; }
        set
        {
            if (value >= 0)
            { bullets = value; }
            else
            {
                bullets = 0;
            }
        }
    }

    public Weapon(int damage, int bullets)
    {
        Bullets = damage;
        Damage = bullets;
    }

    public void Fire(Player player)
    {
        
        if (bullets > 0)
        {
            player.Health -= damage;
            Bullets -= 1;
        }
        else
        {
            return;
        }
    }
}