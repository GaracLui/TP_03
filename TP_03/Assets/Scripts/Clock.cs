using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI hours;
    public TextMeshProUGUI minutes;
    public TextMeshProUGUI seconds;

    public int timeMultiplier;

    private float hours_;
    private float minutes_;
    private float seconds_;
    // Start is called before the first frame upda
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds_= timeMultiplier * Time.deltaTime;

        seconds.text = seconds_.ToString("00");
        minutes.text = minutes_.ToString("00");
        hours.text = hours_.ToString("00");

        if (seconds_ > 59)
        {
            seconds_ = 0;
            minutes_++;
        }
        if (minutes_ > 59)
        {
            minutes_ = 0;
            hours_++;
        }
        if (hours_ > 23)
        {
            hours_ = 0;
            minutes_= 0;
            seconds_ = 0;
        }
    }
}
