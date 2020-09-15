using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVampire : Enemy
{
    protected float Speed = 10f;
    float chaseSpeed = 20f;

    public EnemyVampire()
    {
        type = 1;
        health = 10;
        name = "Green Zombie";
        range = 5;

        void OnTriggerEnter(Collider c)
        {
            if (c.gameObject.tag == "Player") //Don't forget to tag the player!
            {
                ChasePlayer(chaseSpeed);

            }

        }
    }

    void Start()
    {
        GetComponent<SphereCollider>().radius = range;
    }
}
