using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timer;
    public float time;
    float ms;
    float s;
    float m;
    private void Start()
    {
        StartCoroutine("StopWatch");
    }
    IEnumerator StopWatch()
    {
        while (true)
        {
            time += Time.deltaTime;
            ms = (int)(time - (int)time) * 100;
            s = (int)(time % 60);
            m = (int)(time / 60 % 60);

            timer.text = string.Format("{0:00}:{1:00}:{2:00}", m, s, ms);
        }
    }
}
