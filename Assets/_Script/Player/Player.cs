using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public string name;
    public int weapon;    

    public virtual void Move()
    {
        //player move
    }

    public virtual void Attack()
    {
        //player attack
    }

}
