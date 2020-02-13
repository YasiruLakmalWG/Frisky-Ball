using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public GameObject ConfirmPanelBack;
    public GameObject ResetConfirmPanel;
    public GameObject OptionPanel;

    public AudioClip click;
    public AudioSource source1;

    //public Slider backMusicSli;
    //public Slider gameSoundSli;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetA()
    {
        source1.PlayOneShot(click);
        OptionPanel.SetActive(false);
        ConfirmPanelBack.SetActive(true);
        ResetConfirmPanel.SetActive(true);
    }
    public void ResetYes()
    {
        source1.PlayOneShot(click);
        Player.NumbCoins = 0;
        Player.powerup1currentLevel = 0;
        Player.powerup2currentLevel = 0;
        Player.FreezecurrentLevel = 0;
        Player.ICcurrentLevel = 0;
        Player.IScurrentLevel = 0;
        Player.CDcurrentLevel = 0;

        Player.SelectedPlayerNumb = 0;

        Player.GrassBallUnlock = false;
        Player.LeatherBallUnlock = false;
        Player.PaperBallUnlock = false;
        Player.SandBallUnlock = false;
        Player.WoodenBallUnlock = false;
        Player.DenimBallUnlock = false;
        Player.StoneBallUnlock = false;
        Player.SoftBallUnlock = false;
        Player.TennisBallUnlock = false;
        Player.ColorBallUnlock = false;

        Player.highscore1 = 0;
        Player.highscore2 = 0;
        Player.highscore3 = 0;
        Player.highscore4 = 0;
        Player.highscore5 = 0;

        //Debug.Log("ICcurr" + Player.ICcurrentLevel);
    }
    public void ResetNo()
    {
        source1.PlayOneShot(click);
        ConfirmPanelBack.SetActive(false);
        ResetConfirmPanel.SetActive(false);
        OptionPanel.SetActive(true);
    }
}
