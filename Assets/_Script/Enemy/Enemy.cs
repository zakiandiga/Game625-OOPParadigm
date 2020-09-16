using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Enemy : MonoBehaviour
{
    public int type;
    public string name;
    public int health;
    public float range;
    //consider get/set to change private var

    public static event Action<Enemy> OnEnemyKill;  

    void Start()
    {
        //PlayerControl.Attack += EnemyKill;
    }

    public virtual void ChasePlayer()
    {
        print("Chasing player");
        //Complete ChasePlayer function here!!
    }

    public virtual void ChasePlayer(float chaseSpeed)
    {
        print("Chase player within range at " + chaseSpeed);
    }

    public void EnemyKill()//PlayerControl player)
    {
        OnEnemyKill(this);
        //Remove this from EnemyRepository
        Destroy(gameObject);
    }


    

}


