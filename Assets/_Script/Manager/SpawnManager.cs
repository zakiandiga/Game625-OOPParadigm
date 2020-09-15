using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    int enemyCount;

    void Start()
    {
        EnemyKillNotifier.OnEnemyKilled += EnemyNumberCount;
        //EnemyKillNotifier.OnEnemyKilled += EnemyKillCount;
    }

    private void EnemyNumberCount (EnemyKillNotifier kill)
    {
        //enemy count -1
    }

    //spawn enemy every x sec if enemyCount < 10

    void Update()
    {
        
    }
}
