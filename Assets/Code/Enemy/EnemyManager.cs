using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float maxDelay = 5f;
    public float minDelay = 1f;
    public float maxSpeed = 5f;

    public GameObject[] spawners;
    public float[] spawnTimes;


    private void Start()
    {
        InvokeRepeating("SpawnEnemies", 0f, 2f);

        spawnTimes = new float[spawners.Length];
        for (int i = 0; i < spawners.Length; i++)
        {
            spawnTimes[i] = Time.time + Random.Range(minDelay, maxDelay);
        }
    }

    public void SpawnEnemies()
    {
        for (int i = 0; i < spawners.Length; i++)
        {
            if (Time.time > spawnTimes[i] && spawners[i].GetComponent<Spawner>().canSpawn)
            {
                spawners[i].GetComponent<Spawner>().speed = Random.Range(1f, maxSpeed);
                spawners[i].GetComponent<Spawner>().SpawnEnemy();
                spawnTimes[i] = Time.time + Random.Range(minDelay, maxDelay);
            }
        }
    }
}
