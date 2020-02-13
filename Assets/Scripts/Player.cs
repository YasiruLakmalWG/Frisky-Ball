using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int NumbCoins;

    public static int highscore1;
    public static int highscore2;
    public static int highscore3;
    public static int highscore4;
    public static int highscore5;

    public static int powerup1currentLevel;
    public static int powerup2currentLevel;
    public static int FreezecurrentLevel;
    public static int ICcurrentLevel;
    public static int IScurrentLevel;
    public static int CDcurrentLevel;

    public static int SelectedPlayerNumb;

    public static bool GrassBallUnlock;
    public static bool LeatherBallUnlock;
    public static bool PaperBallUnlock;
    public static bool SandBallUnlock;
    public static bool WoodenBallUnlock;
    public static bool DenimBallUnlock;
    public static bool StoneBallUnlock;
    public static bool SoftBallUnlock;
    public static bool TennisBallUnlock;
    public static bool ColorBallUnlock;

    public static float BackMusic;
    public static float GameSound;

    // Start is called before the first frame update
    void Start()
    {
        PlayerData data = SaveLoad.LoadPlayer();

        NumbCoins = data.NumbCoins;

        highscore1 = data.highscore1;
        highscore2 = data.highscore2;
        highscore3 = data.highscore3;
        highscore4 = data.highscore4;
        highscore5 = data.highscore5;

        powerup1currentLevel = data.powerup1currentLevel;
        powerup2currentLevel = data.powerup2currentLevel;
        FreezecurrentLevel = data.FreezecurrentLevel;
        ICcurrentLevel = data.ICcurrentLevel;
        IScurrentLevel = data.IScurrentLevel;
        CDcurrentLevel = data.CDcurrentLevel;

        SelectedPlayerNumb = data.SelectedPlayerNumb;

        GrassBallUnlock = data.GrassBallUnlock;
        LeatherBallUnlock = data.LeatherBallUnlock;
        PaperBallUnlock = data.PaperBallUnlock;
        SandBallUnlock = data.SandBallUnlock;
        WoodenBallUnlock = data.WoodenBallUnlock;
        DenimBallUnlock = data.DenimBallUnlock;
        StoneBallUnlock = data.StoneBallUnlock;
        SoftBallUnlock = data.SoftBallUnlock;
        TennisBallUnlock = data.TennisBallUnlock;
        ColorBallUnlock = data.ColorBallUnlock;

        BackMusic = data.BackMusic;
        GameSound = data.GameSound;
        
        //Debug.Log(NumbCoins);
    }

    // Update is called once per frame
    void Update()
    {
        //NumbCoins = NumbCoins + 1;
        SaveLoad.SavePlayer(this);
    }
}
