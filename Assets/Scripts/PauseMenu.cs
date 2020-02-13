using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaaused = false;
    public GameObject ResumeMenu;
    public GameObject OptionMenu;
    public GameObject GamePlane;
    public GameObject ConfirmBackPlane;
    public GameObject LeavePlane;

    public AudioClip click;
    public AudioSource source1;
    public AudioSource background;

    public Slider backMusicSli;
    public GameObject backgroundMusicIcon;
    public Slider gameSoundSli;
    public GameObject gameSoundIcon;

    void Start()
    {
        PlayerData data = SaveLoad.LoadPlayer();
        Player.GameSound = data.GameSound;
        Player.BackMusic = data.BackMusic;
        gameSoundSli.value = Player.GameSound;
        backMusicSli.value = Player.BackMusic;
        //Debug.Log(Player.GameSound);
        source1.volume = Player.GameSound;
        background.volume = Player.BackMusic;
        if (Player.GameSound == 0)
        {
            gameSoundIcon.SetActive(false);
        }
        else
        {
            gameSoundIcon.SetActive(true);
        }
        if (Player.BackMusic == 0)
        {
            backgroundMusicIcon.SetActive(false);
        }
        else
        {
            backgroundMusicIcon.SetActive(true);
        }
    }
    public void pause()
    {
        source1.PlayOneShot(click);
        Player.NumbCoins += PlayerMove.currentMissionCoins;
        ResumeMenu.SetActive(true);
        OptionMenu.SetActive(false);
        GamePlane.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaaused = true;
    }
    public void resume()
    {
        source1.PlayOneShot(click);
        ResumeMenu.SetActive(false);
        OptionMenu.SetActive(false);
        GamePlane.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaaused = false;
    }
    public void options()
    {
        source1.PlayOneShot(click);
        ResumeMenu.SetActive(false);
        OptionMenu.SetActive(true);
        GamePlane.SetActive(false);
    }

    ////////////////// Main Menu ///////////////////////////////////////////

    public void mainMenu()
    {
        source1.PlayOneShot(click);
        ResumeMenu.SetActive(false);
        ConfirmBackPlane.SetActive(true);
        LeavePlane.SetActive(true);
    }
    public void mainMenuYes()
    {
        source1.PlayOneShot(click);
        Time.timeScale = 1f;
        GameIsPaaused = false;
        SceneManager.LoadScene("MainMenu");
    }
    public void mainMenuNo()
    {
        source1.PlayOneShot(click);
        LeavePlane.SetActive(false);
        ConfirmBackPlane.SetActive(false);
        ResumeMenu.SetActive(true);
    }
    /////////////////////////////////////////////////////////////////////////

    public void back()
    {
        source1.PlayOneShot(click);
        ResumeMenu.SetActive(true);
        OptionMenu.SetActive(false);
        GamePlane.SetActive(false);
    }
    public void ChangeGameSound()
    {
        Player.GameSound = gameSoundSli.value;
        source1.volume = Player.GameSound;
        if (Player.GameSound == 0)
        {
            gameSoundIcon.SetActive(false);
        }
        else
        {
            gameSoundIcon.SetActive(true);
        }
    }
    public void ChangeBackgroundMusic()
    {
        Player.BackMusic = backMusicSli.value;
        background.volume = Player.BackMusic;
        if (Player.BackMusic == 0)
        {
            backgroundMusicIcon.SetActive(false);
        }
        else
        {
            backgroundMusicIcon.SetActive(true);
        }
    }
}
