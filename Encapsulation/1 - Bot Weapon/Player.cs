using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int health;

    public Player(int health)
    {
        Health = health;
    }
 
    public int Health
    {
        get { return health; }
        set {
            if(value > 0)
            {health = value;}
        }
    }
}