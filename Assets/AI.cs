using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private Transform Player;
    public float startSpeed;
    private float speed;
   
   
    private float currentdist;
 
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        startSpeed = 1f;
        speed = startSpeed;


    }

    private void LookAwayFrom(Vector3 point)
    {
        point = 2.0f * transform.position - point;
        // point = new Vector3(point.x, point.y, point.z);
        currentdist = Vector3.Distance(transform.position, Player.position);

        if (currentdist < 5)
        {

            speed -= currentdist * Time.deltaTime;
           
        }
        else
        {
          
            speed = startSpeed;

        }
        transform.LookAt(point );
        //transform.position = Vector3.Lerp(transform.position, new Vector3(point.x,0,point.z), speed);
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }
  
    private void FixedUpdate()
    {
        LookAwayFrom(Player.position);
       
       
       
    }
  
}
