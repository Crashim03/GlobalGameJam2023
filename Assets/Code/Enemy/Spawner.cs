using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 1f);
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemyPrefab.GetComponent<Enemy>().playerPosition = GameObject.Find("Player").transform;
    }
}
