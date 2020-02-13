using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLight2 : MonoBehaviour
{
    public Rigidbody light2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (light2.position.z <= 260)
        {
            light2.velocity = new Vector3(0, 0, 40);
        }
        if (light2.position.z >= 420)
        {
            light2.velocity = new Vector3(0, 0, -40);
        }

    }
}
