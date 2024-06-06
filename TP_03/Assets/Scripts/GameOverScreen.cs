using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOver;
    public void Setup()
    {
        gameOver.SetActive(true);
    }
    // Start is called before the first frame update
    public void RestartButton()
    {
        // Buelve a cargar el nivel actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}
