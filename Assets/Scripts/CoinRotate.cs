using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public int NumbCoins;
    public PlayerMove playerMove;
    public PowerUps powerUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 3);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(this.transform.position.x, 50, this.transform.position.z);
            if (powerUp.CoinD == true)
            {
                PlayerMove.currentMissionCoins += 2;
            }
            if (powerUp.CoinD == false)
            {
                PlayerMove.currentMissionCoins++;
            }
            StartCoroutine(coinReplace());
        }
    }

    IEnumerator coinReplace()
    {
        yield return new WaitForSeconds(5);
        this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z);
    }
}
