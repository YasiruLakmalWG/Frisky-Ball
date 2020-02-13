using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBox : MonoBehaviour
{
    public PowerUps powerUps;

    public Rigidbody cube;
    public int initialX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //cube.velocity = new Vector3(-1, 0, 0);
        if(powerUps.Freeze == true)
        {
            initialState();
            cube.velocity = new Vector3(0, 0, 0);
        }
        if (powerUps.Freeze == false)
        {
            //initialState();
        
            if (cube.position.x >= 1)
            {
                cube.velocity = new Vector3(-0.5f, 0, 0);
            }
            if (cube.position.x <= -1)
            {
                cube.velocity = new Vector3(0.5f, 0, 0);
            }
        }
    }
    void initialState()
    {
        cube.position = new Vector3(initialX,cube.position.y,cube.position.z);
    }
}
