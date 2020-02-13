using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{
    public GameObject countDownPanel;
    public GameObject Player;
    public Text count;
    public GameObject openAnim;
    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(false);
        countDownPanel.SetActive(true);
        openAnim.SetActive(true);
        StartCoroutine(CountD());

    }

    IEnumerator CountD()
    {
        yield return new WaitForSeconds(2f);
        openAnim.SetActive(false);
        count.text = "3";
        yield return new WaitForSeconds(1f);
        count.text = "2";
        yield return new WaitForSeconds(1f);
        count.text = "1";
        yield return new WaitForSeconds(1f);
        count.text = "GO";
        yield return new WaitForSeconds(1f);
        count.text = "";
        Player.SetActive(true);
        countDownPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
