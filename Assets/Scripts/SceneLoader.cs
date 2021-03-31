using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene ()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void LoadStartMenu()
    {
        int startSceneIndex = 0;
        SceneManager.LoadScene(startSceneIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
