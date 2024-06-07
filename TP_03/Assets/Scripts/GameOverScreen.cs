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
        gameOver.SetActive(true); // Muestra el GameObject oculto
    }
    

    public void RestartButton()
    {
        // Vuelve a cargar el nivel actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Obtiene el index de la escena actual
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}
