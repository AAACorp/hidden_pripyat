using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float millisecond;
    int second;
    public int minute;
    public TextMesh text;

    void TimerTick()
    {
        millisecond -= 0.02f;
        if (millisecond <= 0)
        {
            millisecond = 1;
            second--;

        }
        if (second == 0)
        {
            second = 59;
            minute--;

        }

        if (second < 10)
        {
            text.text = minute + " : " + "0" + second;
        }
        else
        {
            text.text = minute + " : " + second;
        }
    }

    void Loose()
    {
        if (second == 1 && minute == 0)
        {
            Application.LoadLevel(1);
        }
    }

    private void Awake()
    {
        minute--;
        second = 59;
        millisecond = 1;
    }

    private void FixedUpdate()
    {
        TimerTick();
    }

    private void Update()
    {
        Loose();
    }
}
