using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public KeyCode spawn;
    public GameObject zombie;
    Vector3 spawnPoint = Vector3.zero;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(spawn))
        {
            Instantiate(zombie, new Vector3(0,0,0), Quaternion.identity);
        }
    }
}
