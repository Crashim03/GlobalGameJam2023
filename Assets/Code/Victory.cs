using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Victory : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    void Start()
    {
        bestScoreText.text = GameObject.FindObjectOfType<Scoreboard>().GetComponent<Scoreboard>().bestScore.ToString("#.##");
    }


}
