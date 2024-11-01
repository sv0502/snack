using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ui : MonoBehaviour
{
    public TMP_Text scoreText;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        
        
        
       //scoreText.text = score.ToString();




    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Resetscore() 
    { 
    score = 0;
        scoreText.text = score.ToString();
    }
    public void AddScore() 
    {
        score = score++;//=score = score + 1
        scoreText.text = score.ToString();
    }

}
