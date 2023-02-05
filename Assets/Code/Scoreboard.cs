using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public float bestScore = 0f;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
