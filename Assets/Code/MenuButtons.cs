using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame() {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex)
        Debug.Log("START GAME!");
    }

    public void ReturnMainMenu() {
        //SceneManager.LoadScene(0) 
        Debug.Log("RETURN TO MAIN MENU!");
    }

    public void Retry() {
        //SceneManager.LoadScene(1)
        Debug.Log("RESTART GAME!"); 
    }

    public void QuitGame() {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
