using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public KeyCode spawn;
    public GameObject zombie;
    Vector3 spawnPoint = Vector3.zero;

    [SerializeField] int enemyCount = 1;

    public List<Enemy> enemyList; //Or gameObject?


    void Start()
    {
        enemyList = new List<Enemy>();
        
        //add enemies to the list from start?
        Enemy.OnEnemyKill += EnemyCountDown;
        
    }

    private void EnemyCountDown(Enemy enemy) //The parameter needs to match the 
    {
        //enemy count -1
        enemyCount -= 1;
    }

    //spawn enemy every x sec if enemyCount < 10
    void SpawnEnemy() 
    {
        if(enemyCount < 10)
        {
            GameObject enemyGameObject = Instantiate(zombie, new Vector3(0, 0, 0), Quaternion.identity);
            EnemyZombie enemy = enemyGameObject.GetComponent<EnemyZombie>();//Randomize enemy from the list
            //add this to EnemyRepository
            enemyList.Add(enemy);
            enemyCount += 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(spawn)) //change the condition
        {
            SpawnEnemy(); //Test
            
        }
    }
}
