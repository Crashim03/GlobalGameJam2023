using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float speed = 1f;
    public GameObject enemyPrefab;
    public bool canSpawn = true;
    private bool boolean;

    public void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        canSpawn = false;
        enemy.GetComponent<Enemy>().playerPosition = GameObject.Find("Player").transform;
        enemy.GetComponent<Enemy>().speed = speed;
        enemy.GetComponent<Enemy>().Spawner = GameObject.Find(gameObject.name);
        boolean = (Random.value > 0.5f);
        enemy.GetComponent<Enemy>().anim.SetBool("W_or_B", boolean);
    }
}
