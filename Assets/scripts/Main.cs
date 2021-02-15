using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    private int indexOfScene;

    private void Start()
    {        
        indexOfScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log($"Номер сцены = {indexOfScene}");
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Continue()
    {
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        Debug.Log("перезагрузка сцены");
        //Continue();
        SceneManager.LoadScene(indexOfScene);        
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(indexOfScene + 1);
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
