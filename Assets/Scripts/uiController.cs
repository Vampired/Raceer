using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiController : MonoBehaviour
{
    public Text scoreText;
    static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ""+score;
    }
    
    void scoreUpdate()
    {
        score +=1;
    }
}
