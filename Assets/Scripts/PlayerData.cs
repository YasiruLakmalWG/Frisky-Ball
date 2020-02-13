using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int NumbCoins;

    public int highscore1;
    public int highscore2;
    public int highscore3;
    public int highscore4;
    public int highscore5;

    public int powerup1currentLevel;
    public int powerup2currentLevel;
    public int FreezecurrentLevel;
    public int ICcurrentLevel;
    public int IScurrentLevel;
    public int CDcurrentLevel;

    public int SelectedPlayerNumb;

    public bool GrassBallUnlock;
    public bool LeatherBallUnlock;
    public bool PaperBallUnlock;
    public bool SandBallUnlock;
    public bool WoodenBallUnlock;
    public bool DenimBallUnlock;
    public bool StoneBallUnlock;
    public bool SoftBallUnlock;
    public bool TennisBallUnlock;
    public bool ColorBallUnlock;

    public float BackMusic;
    public float GameSound;

    public PlayerData(Player player)
    {
        NumbCoins = Player.NumbCoins;

        highscore1 = Player.highscore1;
        highscore2 = Player.highscore2;
        highscore3 = Player.highscore3;
        highscore4 = Player.highscore4;
        highscore5 = Player.highscore5;

        powerup1currentLevel = Player.powerup1currentLevel;
        powerup2currentLevel = Player.powerup2currentLevel;
        FreezecurrentLevel = Player.FreezecurrentLevel;
        ICcurrentLevel = Player.ICcurrentLevel;
        IScurrentLevel = Player.IScurrentLevel;
        CDcurrentLevel = Player.CDcurrentLevel;

        SelectedPlayerNumb = Player.SelectedPlayerNumb;

        GrassBallUnlock = Player.GrassBallUnlock;
        LeatherBallUnlock = Player.LeatherBallUnlock;
        PaperBallUnlock = Player.PaperBallUnlock;
        SandBallUnlock = Player.SandBallUnlock;
        WoodenBallUnlock = Player.WoodenBallUnlock;
        DenimBallUnlock = Player.DenimBallUnlock;
        StoneBallUnlock = Player.StoneBallUnlock;
        SoftBallUnlock = Player.SoftBallUnlock;
        TennisBallUnlock = Player.TennisBallUnlock;
        ColorBallUnlock = Player.ColorBallUnlock;

        BackMusic = Player.BackMusic;
        GameSound = Player.GameSound;
    }
}
