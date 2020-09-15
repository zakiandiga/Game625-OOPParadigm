using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyKillNotifier : MonoBehaviour
{
    public static event Action<EnemyKillNotifier> OnEnemyKilled; //this is static get this reference without geting the object

    // Start is called before the first frame update
    void Start()
    {

    }

    //Can we put EnemyBornNotifier here?

    private void OnDestroy()
    {
        if (OnEnemyKilled != null)
        {
            OnEnemyKilled(this);
        }
    }
    

}
