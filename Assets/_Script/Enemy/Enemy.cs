using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int type;
    public string name;
    public int health;
    public float range;

    public virtual void ChasePlayer()
    {
        print("Chasing player");
        //Complete ChasePlayer function here!!
    }

    public virtual void ChasePlayer(float chaseSpeed)
    {
        print("Chase player within range at " + chaseSpeed);
    }


    

}


