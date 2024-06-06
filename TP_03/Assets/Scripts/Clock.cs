using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI clockText;
    public GameOverScreen gameOver;
    public float startTime = 60f; // Adjust this to your desired starting time in seconds

    private float currentTime;

    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        // cuan los segundos se acaben
        if (currentTime <= 0f)
        {
            currentTime = 0f;
            gameOver.Setup();

        }

        // Format the time string with leading zeros for a consistent display
        clockText.text = string.Format("{0:00}:{1:00}", Mathf.FloorToInt(currentTime / 60f), Mathf.FloorToInt(currentTime % 60f));
    }
}
