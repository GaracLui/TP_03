using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI clockText;
    public float startTime = 60f; // Adjust this to your desired starting time in seconds

    public GameOverScreen gameOver; // Indica que canvas mostrar en caso de que se acabe el tiempo

    private float currentTime;

    public float CurrentTime { get => currentTime; set => currentTime = value; }

    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        

        // cuan los segundos se acaben
        if (currentTime <= 0f)
        {
            currentTime = 0f; // los segundos siempre estaran en 0
            clockText.text = string.Format("{0:00}:{1:00}", Mathf.FloorToInt(currentTime / 60f), Mathf.FloorToInt(currentTime % 60f));
            gameOver.Setup(); // Muestra canvas con fin de la partida (GAME OVER)

        }
        else
        {
            // Temporizador en reversa
            currentTime -= Time.deltaTime;

            /* {0:00} -> ("{0}" indica cual de los elementos siguientes mostrar, en este caso el de index 0);
             * {0:00} -> ("{:00}" indica cuantos digitos mostrar, en este caso solo muestra las decenas y las unidades)
             */
            clockText.text = string.Format("{0:00}:{1:00}", Mathf.FloorToInt(currentTime / 60f), Mathf.FloorToInt(currentTime % 60f));
        }

        
    }
}
