using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float maxDelay = 5f;
    public float minDelay = 1f;
    public float maxSpeed = 5f;
    public float minSpeed = 1f;

    public GameObject[] spawners;
    public float[] spawnTimes;
    public int level = 1;


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
                spawners[i].GetComponent<Spawner>().speed = Random.Range(minSpeed, maxSpeed);
                spawners[i].GetComponent<Spawner>().SpawnEnemy();
                spawnTimes[i] = Time.time + Random.Range(minDelay, maxDelay);
            }
        }
    }

    public void NextLevel()
    {
        if (level < 3)
        {
            level++;
            maxSpeed += 2f;
            minSpeed += 1f;
            maxDelay -= 0.5f;
            minDelay += 0.5f;
            GameObject.Find("Background").GetComponent<Animator>().SetFloat("Level", level);
        }
        else
        {
            SceneManager.LoadScene("VictoryMenu");
        }
    }
}
