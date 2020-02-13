using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscorePrint : MonoBehaviour
{
    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;
    public Text highScore5;
    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = Player.highscore1.ToString();
        highScore2.text = Player.highscore2.ToString();
        highScore3.text = Player.highscore3.ToString();
        highScore4.text = Player.highscore4.ToString();
        highScore5.text = Player.highscore5.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
