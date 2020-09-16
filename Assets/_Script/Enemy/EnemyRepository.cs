using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRepository : Enemy
{
    //How to add zombies to this repository?
    //Where to attach this script to?

    public List<Enemy> enemyList;
    
    void Start()
    {
        enemyList = new List<Enemy>();
        
    }

}
