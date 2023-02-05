using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame()
    {
        Destroy(GameObject.FindObjectOfType<Scoreboard>());
        SceneManager.LoadScene("MainScene");
        Debug.Log("START GAME!");
    }

    public void ReturnMainMenu()
    {
        Destroy(GameObject.FindObjectOfType<Scoreboard>());
        SceneManager.LoadScene("MainMenu");
        Debug.Log("RETURN TO MAIN MENU!");
    }

    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("RESTART GAME!");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
