using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private Transform Player;
    public float speed;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        speed = 0.0029f;
   ;
    }

    private void LookAwayFrom(Vector3 point)
    {
        point = 2.0f * transform.position - point;
        // point = new Vector3(point.x, point.y, point.z);
        point.z = point.x;
        transform.LookAt(point );
        transform.position = Vector3.Lerp(transform.position, new Vector3(point.x,point.y,0), speed);
     
    }
  
    private void FixedUpdate()
    {
        LookAwayFrom(Player.position);
       
    }
   
}
