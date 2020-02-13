using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(this.transform.position.x, 50, this.transform.position.z);
            StartCoroutine(powerUpReplace());
        }
    }
    IEnumerator powerUpReplace()
    {

        yield return new WaitForSeconds(5);
        this.transform.position = new Vector3(this.transform.position.x, 1, this.transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,3);
    }
}
