using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject CompleteLevelUI;
    public void CompleteLevel()
    {
        Debug.Log("WON");
        CompleteLevelUI.SetActive(true);
        Invoke("LoadNextLevel", 2f);
    }
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", 1f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        CompleteLevelUI.SetActive(false);
    }
}
