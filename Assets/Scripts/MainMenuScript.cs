using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //public Player player;
    public GameObject MainPanel;
    public GameObject OptionPanel;
    public Text CoinCount;
    public GameObject StatusPanel;
    public GameObject StorePanel;
    public GameObject StoreMenuPanel;
    public GameObject MainStorePanel;
    public GameObject PlayerSelectPanel;
    public GameObject PowerupsUpgradePanel;

    public GameObject confirmPanelBack;
    public GameObject quitConfirmPanel;

    public GameObject MenuToPlay;

    public AudioClip click;
    public AudioSource gameSound;
    public AudioClip music1;
    public AudioSource background;

    public Slider backMusicSli;
    public GameObject backgroundMusicIcon;
    public Slider gameSoundSli;
    public GameObject gameSoundIcon;


    void Start()
    {
        Debug.Log(Player.GameSound);
        PlayerData data = SaveLoad.LoadPlayer();
        Player.NumbCoins = data.NumbCoins;
        Player.GameSound = data.GameSound;
        Player.BackMusic = data.BackMusic;
        CoinCount.text = Player.NumbCoins.ToString();
        MenuToPlay.SetActive(false);
        MainPanel.SetActive(true);

        gameSoundSli.value = Player.GameSound;
        backMusicSli.value = Player.BackMusic;
        //Debug.Log(Player.GameSound);
        gameSound.volume = Player.GameSound;
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
    void Update()
    {
        CoinCount.text = Player.NumbCoins.ToString();
    }

   public void Play()
    {
        //powerUp1time = 50f;
        gameSound.PlayOneShot(click);
        MenuToPlay.SetActive(true);
        StartCoroutine(PlayScene());
        
    }
    IEnumerator PlayScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("PlayScene");
    }

    public void Options()
    {
        gameSound.PlayOneShot(click);
        MainPanel.SetActive(false);
        OptionPanel.SetActive(true);
    }
    //Quit Buttons/////////////////////////////////////////////////
    public void Quit()
    {
        gameSound.PlayOneShot(click);
        MainPanel.SetActive(false);
        confirmPanelBack.SetActive(true);
        quitConfirmPanel.SetActive(true);
        
    }
    public void QuitYes()
    {
        gameSound.PlayOneShot(click);
        Application.Quit();
    }
    public void QuitNo()
    {
        gameSound.PlayOneShot(click);
        quitConfirmPanel.SetActive(false);
        confirmPanelBack.SetActive(false);
        MainPanel.SetActive(true);
    }
    /////////////////////////////////////////////////////////////
    public void Back()
    {
        gameSound.PlayOneShot(click);
        OptionPanel.SetActive(false);
        MainPanel.SetActive(true);
    }

    public void MainMenu()
    {
        gameSound.PlayOneShot(click);
        SceneManager.LoadScene("MainMenu");
    }
    public void Status()
    {
        gameSound.PlayOneShot(click);
        StatusPanel.SetActive(true);
        MainPanel.SetActive(false);
    }
    public void StatusBack()
    {
        gameSound.PlayOneShot(click);
        MainPanel.SetActive(true);
        StatusPanel.SetActive(false);
    }
    public void Store()
    {
        gameSound.PlayOneShot(click);
        StorePanel.SetActive(true);
        MainPanel.SetActive(false);
    }
    public void StoreBack()
    {
        gameSound.PlayOneShot(click);
        MainPanel.SetActive(true);
        StorePanel.SetActive(false);
    }
    public void PlayerSelect()
    {
        gameSound.PlayOneShot(click);
        MainStorePanel.SetActive(true);
        PlayerSelectPanel.SetActive(true);
        StoreMenuPanel.SetActive(false);
    }
    public void PowerUpdate()
    {
        gameSound.PlayOneShot(click);
        MainStorePanel.SetActive(true);
        PowerupsUpgradePanel.SetActive(true);
        StoreMenuPanel.SetActive(false);
    }
    public void PlayerSelectBack()
    {
        gameSound.PlayOneShot(click);
        StoreMenuPanel.SetActive(true);
        PlayerSelectPanel.SetActive(false);
        PowerupsUpgradePanel.SetActive(false);
        MainStorePanel.SetActive(false);
        Debug.Log("3");

    }

    public void ChangeGameSound()
    {
        Player.GameSound = gameSoundSli.value;
        gameSound.volume = Player.GameSound;
        if(Player.GameSound == 0)
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
