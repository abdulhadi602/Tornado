using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBox3D : MonoBehaviour
{
   

    private Transform Player;




    private float smoothSpeed = 0.04f;
    public Vector3 offset;
    private Vector3 desiredPosition;
    private Vector3 smoothedPosition;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
 


    private void FixedUpdate()
    {
        if (Player != null)
        {
            desiredPosition = Player.position + offset;

            smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
           

        }
        // transform.LookAt(Player);
    }
}
