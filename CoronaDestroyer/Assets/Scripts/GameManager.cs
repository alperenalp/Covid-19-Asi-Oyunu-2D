using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null) //eger player �ld�yse destroy olduysa.
        {
            gameOverPanel.SetActive(true); //gameOver ekran�n� a�
        }
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
