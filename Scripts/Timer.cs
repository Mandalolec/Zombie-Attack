using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 0;
    public Text timerText;

    void Start()
    {
        timerText.text = timeStart.ToString("F2");
    }

    
    void Update()
    {
        timeStart += Time.deltaTime;
        timerText.text = timeStart.ToString("F2");
    }
}
