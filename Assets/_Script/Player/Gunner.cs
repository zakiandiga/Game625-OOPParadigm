using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunner : Player
{
    [SerializeField]
    protected int health;
    protected int speed;
    
    public Gunner()
    {
        name = "Gunner";
        weapon = 1;
        
    
    }
}
