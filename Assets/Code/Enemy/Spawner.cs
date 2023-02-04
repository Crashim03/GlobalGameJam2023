using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float speed = 1f;
    public GameObject enemyPrefab;

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        enemyPrefab.GetComponent<Enemy>().playerPosition = GameObject.Find("Player").transform;
        enemyPrefab.GetComponent<Enemy>().speed = speed;
    }
}
