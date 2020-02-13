using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpMenu : MonoBehaviour
{
    public PowerUps Powerup;

    public Image timeBar;
    public float timeLeft;
    public float maxTime;
    int i = 0;

    public Text Instructions;
    public GameObject powerpanel;
    public Text powerName;
    public GameObject loadBar;

    public Sprite powerup1Img;
    public Sprite powerup2Img;
    public Sprite FreezeImg;
    public Sprite NoCubeImg;
    public Sprite NoSphereImg;
    public Sprite DoubCoinImg;

    // Start is called before the first frame update
    void Start()
    {
        Instructions.text = "";
        powerpanel.SetActive(false);
        powerName.text = "";
        loadBar.SetActive(false);
        PowerUpUpgrade.powerUp1time = Player.powerup1currentLevel;
    }

    // Update is called once per frame
    void Update()
    {
        if(Powerup.Powerup1 == true)
        {
            timeBar.sprite = powerup1Img;
            powerpanel.SetActive(true);
            powerName.text = "Collide Free";
            loadBar.SetActive(true);
            Process();
        }
        if (Powerup.Powerup2 == true)
        {
            timeBar.sprite = powerup2Img;
            powerpanel.SetActive(true);
            powerName.text = "Trap Free";
            loadBar.SetActive(true);
            Process();
        }
        if (Powerup.Freeze == true)
        {
            timeBar.sprite = FreezeImg;
            powerpanel.SetActive(true);
            powerName.text = "Freeze";
            loadBar.SetActive(true);
            Process();
        }
        if (Powerup.Invisible == true)
        {
            timeBar.sprite = NoCubeImg;
            powerpanel.SetActive(true);
            powerName.text = "No Cubes";
            loadBar.SetActive(true);
            Process();
        }
        if (Powerup.InvisibleSp == true)
        {
            timeBar.sprite = NoSphereImg;
            powerpanel.SetActive(true);
            powerName.text = "No Spheres";
            loadBar.SetActive(true);
            Process();
        }
        if (Powerup.CoinD == true)
        {
            timeBar.sprite = DoubCoinImg;
            powerpanel.SetActive(true);
            powerName.text = "Double Coin";
            loadBar.SetActive(true);
            Process();
        }
        if (Powerup.Health == true)
        {
            Instructions.text = "Health +";
        }
        if (Powerup.PowerUpEnable == false)
        {
            End();
        }

    }

    private void Process()
    {
        if (i == 0)
        {
            i = 1;
            timeBar.fillAmount = 1;
            timeLeft = Powerup.poweruptime;
            maxTime = Powerup.poweruptime;
        }
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;
        }
    }

    private void End()
    {
        timeLeft = 0f;
        maxTime = 0f;
        i = 0;
        Instructions.text = "";
        powerpanel.SetActive(false);
        powerName.text = "";
        loadBar.SetActive(false);
    }
    }
