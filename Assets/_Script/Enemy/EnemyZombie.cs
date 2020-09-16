using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZombie : Enemy
{
    protected float Speed = 5f;
    [SerializeField] protected int Score = 10;
    
    public KeyCode Kill; //Temporary

    

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

        
    }

    void ChasePlayer()
    {
        //zombie version
    }

    void Start()
    {
        GetComponent<SphereCollider>().radius = range;
    }


}
