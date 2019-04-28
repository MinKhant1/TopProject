using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset;
    public float smoothSpeed= 0.125f;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void FixedUpdate ()
    {

        transform.LookAt(player.transform.position);
        Vector3 desiredPosition= player.transform.position + offset;
        Vector3 smoothedPositon = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPositon;
        
       

		
	}
}
