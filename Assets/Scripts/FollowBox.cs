﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBox : MonoBehaviour
{
    public Transform Dummy;

    public Transform Player;




    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private Vector3 desiredPosition;
    private Vector3 smoothedPosition;
  
    public void SetNewInstance(Transform instance)
    {
        Dummy = instance;
    }
   


    private void FixedUpdate()
    {
        if (Dummy != null)
        {
                desiredPosition = Dummy.position + offset;
        
                smoothedPosition = Vector3.Lerp(transform.position,new Vector3(transform.position.x, desiredPosition.y, transform.position.z), smoothSpeed);
                transform.position = smoothedPosition;
            if(transform.position.y - Dummy.position.y < 10)
            {
                TouchSC.TouchEnabled = true;
                Player.transform.GetChild(0).gameObject.SetActive(true);
               
            }
        
        }
        // transform.LookAt(Player);
    }
}
