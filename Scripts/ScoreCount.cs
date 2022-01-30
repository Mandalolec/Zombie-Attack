using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text textScore;
    public static int enemys;
    void Start()
    {
        textScore.GetComponent<Text>();
    }

    
    void Update()
    {
        textScore.text = enemys.ToString();
    }
}
