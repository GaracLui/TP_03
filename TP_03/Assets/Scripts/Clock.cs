using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI clockText;
    public float startTime = 60f; // Adjust this to your desired starting time in seconds

    private float currentTime;

    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            currentTime = 0f;
        }

        // Format the time string with leading zeros for a consistent display
        clockText.text = string.Format("{0:00}:{1:00}", Mathf.FloorToInt(currentTime / 60f), Mathf.FloorToInt(currentTime % 60f));
    }
}
