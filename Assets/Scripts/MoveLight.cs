using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLight : MonoBehaviour
{
    public Rigidbody light1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (light1.position.z <= 442)
        {
            light1.velocity = new Vector3(0, 0, 40);
        }
        if (light1.position.z >= 602)
        {
            light1.velocity = new Vector3(0, 0, -40);
        }
        
    }
}
