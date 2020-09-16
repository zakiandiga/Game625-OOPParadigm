using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class EnemySpawner : MonoBehaviour
{
    GameObject scoreBoard;
    Text txt;

    public GameObject zombie;
    Vector3 spawnPoint = Vector3.zero;

    [SerializeField] int enemyCount = 1;
    [SerializeField] int enemyMax = 10;
    bool isRespawning = false;
    float respawnTime = 5f;

    public List<Enemy> enemyList; //Or gameObject?




    void Start()
    {
        enemyList = new List<Enemy>();

        scoreBoard = GameObject.Find("EnemyBoard");
        txt = scoreBoard.GetComponent<Text>();
     
        Enemy.OnEnemyKill += EnemyCountDown;
        Enemy.OnEnemyKill += EnemyKillSound;
        //Enemy.OnEnemyKill += EnemyAddDisplay;
    }

    private void EnemyKillSound(Enemy enemy)
    {
        //Play Sound
    }

    private void EnemyCountDown(Enemy enemy) 
    {
        //enemy count -1
        enemyCount -= 1;

        for (int i = enemyList.Count -1 ; i >= 0; i--)
        {
            if (enemyList[i] == null)
            {
                enemyList.RemoveAt(i);
            }
        }


    }

    IEnumerator SpawnEnemy()
    {
        
        while (enemyCount < enemyMax)
        {
            isRespawning = true;
            float posX = Random.Range(-5, 5);
            float posY = 0;
            float posZ = Random.Range(-5, 5);

            GameObject enemyGameObject = Instantiate(zombie, new Vector3(posX, posY, posZ), Quaternion.identity);
            EnemyZombie enemy = enemyGameObject.GetComponent<EnemyZombie>();//Randomize enemy from the list
            //add this to EnemyRepository
            enemyList.Add(enemy);


            
            enemyCount += 1;            
            
            yield return new WaitForSeconds(respawnTime);
            isRespawning = false;

            Debug.Log("RESPAWN");
            EnemyAddDisplay();

        }
    }

    private void EnemyAddDisplay()
    {
        //Still can't figured out how to get the name of element in list to put on the UI
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount < enemyMax && isRespawning == false)
        {            
            StartCoroutine(SpawnEnemy());
        }
    }
}
