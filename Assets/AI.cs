using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private Transform Player;
    public float startSpeed;
    private float speed;
   
   
    private float currentdist;
    private Vector3 ForwardUp;
    private bool isAttaracted;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        startSpeed = 1f;
        speed = startSpeed;
        isAttaracted = false;
        ForwardUp = new Vector3(0, -1, 1);
    }

    private void LookAwayFrom(Vector3 point)
    {
        point = 2.0f * transform.position - point;
        // point = new Vector3(point.x, point.y, point.z);
        currentdist = Vector3.Distance(transform.position, Player.position);

        if (currentdist < 7)
        {
            isAttaracted = true;    
        }
        
            if (!isAttaracted)
            {
                speed = startSpeed;
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
        
        else
        {
            speed -= currentdist * Time.deltaTime*4;
            transform.Translate(ForwardUp * speed * Time.deltaTime);
        }
        transform.LookAt(point );
        //transform.position = Vector3.Lerp(transform.position, new Vector3(point.x,0,point.z), speed);
        
    }
  
    private void FixedUpdate()
    {
        LookAwayFrom(Player.position);
       
       
       
    }
  
}
