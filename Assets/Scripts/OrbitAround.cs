using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitAround : MonoBehaviour
{
    public Transform RotateAroundObj;
    public float speed;
    public float movementspeed;
    // Update is called once per frame
    void Update()
    {
       
        transform.RotateAround(RotateAroundObj.position, RotateAroundObj.up,speed*Time.deltaTime);
        if (transform.position.x - RotateAroundObj.position.x > 1 )
        {
            transform.position = Vector3.Lerp(transform.position, RotateAroundObj.position, movementspeed);
        }
        transform.LookAt(RotateAroundObj);
    }
}
