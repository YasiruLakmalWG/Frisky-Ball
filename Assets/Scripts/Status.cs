using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public int currentCoins;
    public int highscore1, highscore2, highscore3, highscore4, highscore5;
    public bool save = false;
    void Start()
    {
        highscore1 = Player.highscore1;
        highscore2 = Player.highscore2;
        highscore3 = Player.highscore3;
        highscore4 = Player.highscore4;
        highscore5 = Player.highscore5;

        currentCoins = PlayerMove.currentMissionCoins;
        if (currentCoins >= highscore1)
        {
            highscore5 = highscore4;
            highscore4 = highscore3;
            highscore3 = highscore2;
            highscore2 = highscore1;
            highscore1 = currentCoins;
            
            Debug.Log(currentCoins);
            Debug.Log("save1");
        }
        else if (currentCoins >= highscore2)
        {
            highscore5 = highscore4;
            highscore4 = highscore3;
            highscore3 = highscore2;
            highscore2 = currentCoins;
            
            Debug.Log("save2");
        }
        else if (currentCoins >= highscore3)
        {
            highscore5 = highscore4;
            highscore4 = highscore3;
            highscore3 = currentCoins;
            
            Debug.Log("save3");
        }
        else if (currentCoins >= highscore4)
        {
            highscore5 = highscore4;
            highscore4 = currentCoins;
            
            Debug.Log("save4");
        }
        else if (currentCoins >= highscore5)
        {
            highscore5 = currentCoins;
            
            Debug.Log("save5");
        }      
    }
            // Update is called once per frame
    void Update()
    {
        Player.highscore1 = highscore1;
        Player.highscore2 = highscore2;
        Player.highscore3 = highscore3;
        Player.highscore4 = highscore4;
        Player.highscore5 = highscore5;
    }
}
