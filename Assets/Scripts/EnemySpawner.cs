using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    GameManager gameManager;

    public GameObject Enemy1Prefab;
    public GameObject Enemy2Prefab;

    public float spawnTime = 2;

    void Start()
    {
        GameObject.FindGameObjectWithTag("GameController");
        GetComponent<GameManager>();
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
    }

    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        //gameManager.CanSpawnEnemy;
        Random.Range(1, 10);
        if (random.range =)
        {

        }
    }
}
