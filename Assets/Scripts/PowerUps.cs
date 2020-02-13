using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour
{
    public PlayerMove playerMove;

    public GameObject PowerUpPanel;
    public GameObject Heart3;
    public GameObject Heart2;

    public bool PowerUpEnable = false;
    //public SphereCollider RBcollider;
    public GameObject powerupSpehere;
    public float poweruptime;

    public Material powerUp1Mat;
    public bool Powerup1;
    public static float powerUp1time;
    

    public Material powerUp2Mat;
    public bool Powerup2;
    public static float powerUp2time;

    public Material FreezeMat;
    public bool Freeze = false;
    public float Freezetime;

    public Material InvisibleMat;
    public bool Invisible = false;
    public float Invisibletime;
    public GameObject Cubes;

    public Material InvisibleSpMat;
    public bool InvisibleSp = false;
    public float InvisibleSptime;
    public GameObject Sphere;

    public Material CoinDMat;
    public bool CoinD = false;
    public float CoinDtime;

    public bool Health;

    public AudioSource audioSource;
    public AudioClip powerUp1Aud;
    public AudioClip powerUp2Aud;
    public AudioClip fReezeAud;
    public AudioClip healthAud;
    public AudioClip InvCubeAud;
    public AudioClip InvSpheAud;
    public AudioClip CoinDoubAud;

    public Image timeBar;
    public float timeLeft;
    void Start()
    {
        PowerTime();
    }
    public void PowerTime()
    {
        for (int i = 0; i < 9; i++)
        {
            if (Player.powerup1currentLevel == i)
            {
                powerUp1time = 6f + 3f * i;
            }
            if (Player.powerup2currentLevel == i)
            {
                powerUp2time = 6f + 3f * i;
            }
            if (Player.FreezecurrentLevel == i)
            {
                Freezetime = 6f + 3f * i;
            }
            if (Player.ICcurrentLevel == i)
            {
                Invisibletime = 6f + 3f * i;
            }
            if (Player.IScurrentLevel == i)
            {
                InvisibleSptime = 6f + 3f * i;
            }
            if (Player.CDcurrentLevel == i)
            {
                CoinDtime = 6f + 3f * i;
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "PowerUp1" && PowerUpEnable == false)
        {
            audioSource.PlayOneShot(powerUp1Aud);
            PowerUpEnable = true;
            Powerup1 = true;
            poweruptime = powerUp1time;
            timeLeft = poweruptime;
            powerupSpehere.GetComponent<MeshRenderer>().material = powerUp1Mat;
            powerupSpehere.SetActive(true);
            StartCoroutine(EndPowerup1());
        }
        if (other.gameObject.tag == "PowerUp2" && PowerUpEnable == false)
        {
            audioSource.PlayOneShot(powerUp2Aud);
            PowerUpEnable = true;
            Powerup2 = true;
            poweruptime = powerUp2time;
            powerupSpehere.GetComponent<MeshRenderer>().material = powerUp2Mat;
            powerupSpehere.SetActive(true);
            StartCoroutine(EndPowerup2());
        }
        if (other.gameObject.tag == "Freeze" && PowerUpEnable == false)
        {
            audioSource.PlayOneShot(fReezeAud);
            PowerUpEnable = true;
            Freeze = true;
            poweruptime = Freezetime;
            powerupSpehere.GetComponent<MeshRenderer>().material = FreezeMat;
            powerupSpehere.SetActive(true);
            StartCoroutine(EndFreeze());
        }
        if (other.gameObject.tag == "Invisible" && PowerUpEnable == false)
        {
            audioSource.PlayOneShot(InvCubeAud);
            PowerUpEnable = true;
            Invisible = true;
            Cubes.SetActive(false);
            poweruptime = Invisibletime;
            powerupSpehere.GetComponent<MeshRenderer>().material = InvisibleMat;
            powerupSpehere.SetActive(true);
            StartCoroutine(EndInvisible());
        }
        if (other.gameObject.tag == "InvisibleSpehere" && PowerUpEnable == false)
        {
            audioSource.PlayOneShot(InvSpheAud);
            PowerUpEnable = true;
            InvisibleSp = true;
            Sphere.SetActive(false);
            poweruptime = InvisibleSptime;
            powerupSpehere.GetComponent<MeshRenderer>().material = InvisibleSpMat;
            powerupSpehere.SetActive(true);
            StartCoroutine(EndInvisibleSp());
        }
        if (other.gameObject.tag == "CoinDouble" && PowerUpEnable == false)
        {
            audioSource.PlayOneShot(CoinDoubAud);
            PowerUpEnable = true;
            CoinD = true;
            poweruptime = CoinDtime;
            powerupSpehere.GetComponent<MeshRenderer>().material = CoinDMat;
            powerupSpehere.SetActive(true);
            StartCoroutine(EndCoinD());
        }
        if (other.gameObject.tag == "Health")
        {
            audioSource.PlayOneShot(healthAud);
            PowerUpEnable = true;
            Health = true;
            if (playerMove.NumbLives == 1)
            {
                playerMove.NumbLives = 2;
                Heart2.SetActive(true);
            }
            else if (playerMove.NumbLives == 2)
            {
                playerMove.NumbLives = 3;
                Heart3.SetActive(true);
            }
            StartCoroutine(EndHealth());
        }
    }
    IEnumerator EndPowerup1()
    {
        yield return new WaitForSeconds(poweruptime);
        Powerup1 = false;
        PowerUpEnable = false;
        powerupSpehere.SetActive(false);
    }
    IEnumerator EndPowerup2()
    {
        yield return new WaitForSeconds(poweruptime);
        Powerup2 = false;
        PowerUpEnable = false;
        powerupSpehere.SetActive(false);
    }
    IEnumerator EndFreeze()
    {
        yield return new WaitForSeconds(poweruptime);
        Freeze = false;
        PowerUpEnable = false;
        powerupSpehere.SetActive(false);
    }
    IEnumerator EndInvisible()
    {
        yield return new WaitForSeconds(poweruptime);
        Invisible = false;
        Cubes.SetActive(true);
        PowerUpEnable = false;
        powerupSpehere.SetActive(false);
    }
    IEnumerator EndInvisibleSp()
    {
        yield return new WaitForSeconds(poweruptime);
        InvisibleSp = false;
        Sphere.SetActive(true);
        PowerUpEnable = false;
        powerupSpehere.SetActive(false);
    }
    IEnumerator EndCoinD()
    {
        yield return new WaitForSeconds(poweruptime);
        CoinD = false;
        PowerUpEnable = false;
        powerupSpehere.SetActive(false);
    }
    IEnumerator EndHealth()
    {
        yield return new WaitForSeconds(2f);
        PowerUpEnable = false;
        Health = false;
    }
}
