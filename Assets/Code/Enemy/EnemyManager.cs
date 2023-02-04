using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public GameObject Spawner4;
    public float maxDelay = 5f;
    public float maxSpeed = 5f;

    public GameObject[] spawners;
    public float[] spawnTimes;


    private void Start()
    {
        spawners = new GameObject[] { Spawner1, Spawner2, Spawner3, Spawner4 };
        InvokeRepeating("SpawnEnemies", 0f, 2f);
        spawnTimes = new float[] { Random.Range(0f, maxDelay), Random.Range(0f, maxDelay), Random.Range(0f, maxDelay), Random.Range(0f, maxDelay) };
    }

    public void SpawnEnemies()
    {
        for (int i = 0; i < spawners.Length; i++)
        {

            spawners[i].GetComponent<Spawner>().SpawnEnemy();
        }
    }
}
