using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombie : Enemy
{
    protected float Speed = 5f;


    public EnemyZombie()
    {
        type = 1;
        health = 10;
        name = "Green Zombie";
        range = 5;

        
        void OnTriggerEnter(Collider c)
        {
            if (c.gameObject.tag == "Player") //Don't forget to tag the player!
            {
                ChasePlayer();

            }
            
        }

        //public override void ChasePlayer();

    }

    void Start()
    {
        GetComponent<SphereCollider>().radius = range;
    }
}
