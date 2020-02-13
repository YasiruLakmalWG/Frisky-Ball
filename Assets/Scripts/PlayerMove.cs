using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    public Rigidbody rb;
    public GameObject RB;
    public Swipe swipeControl;
    public Player player;
    public PauseMenu pauseMenu;
    public PowerUps powerUps;

    public float horizVel = 0;
    public float vertVel = 0;
    public float forwardSpeed = 2;
    private float finalSpeed;
    public int laneNumb = 0;
    public string contLock = "n";
    public GameObject collide;
    public bool up;
    public int NumbLives;
    public static int currentMissionCoins;
    public GameObject Heart1, Heart2, Heart3;
    public Text coinNumb;
    public int place;
    public bool Placing;
    public Vector3 StartP;
    public int positionX;
    public GameObject level2;

    public AudioSource audioSource;
    public AudioClip slide;
    public AudioClip jump;
    public AudioClip fail1;
    public AudioClip fail2;
    public AudioClip begin;
    public AudioClip swithLevel;
    public AudioClip coin;
    public AudioClip GameFail;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        coinNumb.text = "0";
        NumbLives = 3;
        currentMissionCoins = 0;
        Placing = true;
        StartPlace();
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Coin")
        {
            audioSource.PlayOneShot(coin);
        }
            if (other.gameObject.tag == "Fail")
        {
            audioSource.PlayOneShot(fail1);
            collide = other.gameObject;
            other.gameObject.SetActive(false);
           if (powerUps.Powerup1 == false) { 
            if (NumbLives == 1)
            {
                audioSource.PlayOneShot(GameFail);
                NumbLives = 0;
                Heart3.SetActive(false);
                Player.NumbCoins += currentMissionCoins;
                SceneManager.LoadScene("RetryScene");
            }
            else if (NumbLives == 2)
            {
                NumbLives = 1;
                Heart2.SetActive(false);
                StartCoroutine(restoreObject());
            }
            else if (NumbLives == 3)
            {
                NumbLives = 2;
                Heart1.SetActive(false);
                StartCoroutine(restoreObject());

            }
            //PerfectLine();
        }
        }
        if (other.gameObject.tag == "UnderGround" && powerUps.Powerup2 == false)
        {
            audioSource.PlayOneShot(fail2);
            if (NumbLives == 1)
            {
                NumbLives = 0;
                Heart3.SetActive(false);
                Player.NumbCoins += currentMissionCoins;
                SceneManager.LoadScene("RetryScene");
            }
            else if (NumbLives == 2)
            {
                NumbLives = 1;
                Heart2.SetActive(false);
                StartCoroutine(restore());
            }
            else if (NumbLives == 3)
            {
                NumbLives = 2;
                Heart1.SetActive(false);
                StartCoroutine(restore());
            }
        }
        if (other.gameObject.tag == "LevelExit")
        {
            forwardSpeed += 2;
        }
        if (other.gameObject.tag == "Floor")
        {
            forwardSpeed -= 2;
        }
        if (other.gameObject.tag == "ExitPoint")
        {
            Placing = true;
            ChoosePlace();
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel,vertVel, forwardSpeed);
        if(horizVel == 0 && Placing == false)
        {
            PerfectLine();
        }
        if (PauseMenu.GameIsPaaused == false)
        {
            forwardSpeed += 0.002f;
        }
        //PerfectLine();
        finalSpeed = forwardSpeed;
        coinNumb.text = currentMissionCoins.ToString();
        if ((swipeControl.SwipeLeft)&& (laneNumb > -1) && (contLock == "n") && PauseMenu.GameIsPaaused == false)
        {
            audioSource.PlayOneShot(slide);
            horizVel = -3;
            laneNumb -= 1;
            contLock = "y";
            StartCoroutine(stopSlide());
        }
        if ((swipeControl.SwipeRight)&& (laneNumb < 1) && (contLock == "n") && PauseMenu.GameIsPaaused == false)
        {
            audioSource.PlayOneShot(slide);
            horizVel = 3;
            laneNumb += 1;
            contLock = "y";
            StartCoroutine(stopSlide());
        }
        if ((swipeControl.SwipeUp) && PauseMenu.GameIsPaaused == false)
        {
            if(up == false)
            {
                audioSource.PlayOneShot(jump);
                up = true;
                vertVel = 3;
                //forwardSpeed = 5;
                StartCoroutine(stopSlide());
            }
           
        }
        //if (swipeControl.SwipeDown)
       // {
      //      Debug.Log("Down");
      //  }
    }
    private void PerfectLine()
    {
        
        if (positionX == 1)
        {
            RB.transform.position = new Vector3(1, RB.transform.position.y, RB.transform.position.z);
        }
        else if (positionX == 0)
        {
            RB.transform.position = new Vector3(0, RB.transform.position.y, RB.transform.position.z);
        }
        else if (positionX == -1)
        {
            RB.transform.position = new Vector3(-1, RB.transform.position.y, RB.transform.position.z);
        }
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(0.33f);
        horizVel = 0;
        vertVel = -3;
        positionX = laneNumb;
        //PerfectLine();
        if (up == true)
        {
            yield return new WaitForSeconds(0.5f);
            forwardSpeed = finalSpeed;
            up = false;
        } 
        contLock = "n";
        Placing = false;
        rb.transform.position = new Vector3(laneNumb, RB.transform.position.y, RB.transform.position.z);
        PerfectLine();
    }

    IEnumerator restore()
    {
        yield return new WaitForSeconds(0.5f);
        if (laneNumb == 1 || laneNumb == -1)
        {
            RB.transform.position = new Vector3(0, 1, RB.transform.position.z);
        }
        if (laneNumb == 0)
        {
            RB.transform.position = new Vector3(1, 1, RB.transform.position.z);
        }
        audioSource.PlayOneShot(swithLevel);
        // PerfectLine();
    }

    IEnumerator restoreObject()
    {
        yield return new WaitForSeconds(2f);
        collide.SetActive(true);
    }

    private void StartPlace()
    {
        place = Random.Range(0, 3);

        if (place == 0)
        {
            StartP = new Vector3(0, 1, -38);
        }
        if (place == 1)
        {
            StartP = new Vector3(0, 1, 55);
        }
        if (place == 2)
        {
            StartP = new Vector3(0, 1, 156);
        }
        Debug.Log(place);
        RB.transform.position = StartP;
        //audioSource.PlayOneShot(begin);
    }
    private void ChoosePlace()
    {
        place = Random.Range(0, 6);
        if (place == 0)
        {
            StartP = new Vector3(0, 1, 255);
        }
        else if (place == 1)
        {
            StartP = new Vector3(0, 1, 437);
        }
        else if (place == 2)
        {
            StartP = new Vector3(0, 1, 621);
        }
        else if (place == 3)
        {
            StartP = new Vector3(0, 1, 806);
        }
        else if (place == 4)
        {
            StartP = new Vector3(0, 1, 995);
        }
        else if (place == 5)
        {
            StartP = new Vector3(0, 1, 1180);
        }
        RB.transform.position = StartP;
    }
}
