using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform lookAt;
    public float smoothTime = 0.3f;
    public Vector3 startOffSet;
    //private Vector3 velocity = Vector3.zero;

    void Start()
    {
       //lookAt = GameObject.FindGameObjectWithTag("Player").transform;
       // startOffSet = transform.position - lookAt.position;
    }

    void LateUpdate()
    {
       // transform.position =  lookAt.position + startOffSet;
       // transform.position = Vector3.SmoothDamp(transform.position, transform.position - lookAt.position, ref velocity, smoothTime);
        Vector3 desiredPosition = lookAt.position + startOffSet;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothTime);
        transform.position = smoothPosition;

        transform.LookAt(lookAt);
    }
}
