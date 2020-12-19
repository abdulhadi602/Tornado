using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private Transform Player;
    public float speed;
    private float posy;
    private float currentPercentage;
    private float currentdist;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        speed = 0.0059f;
        posy = 0;
    }

    private void LookAwayFrom(Vector3 point)
    {
        point = 2.0f * transform.position - point;
        // point = new Vector3(point.x, point.y, point.z);
        
        transform.LookAt(point );
        transform.position = Vector3.Lerp(transform.position, new Vector3(point.x,0,point.z), speed);
        transform.Translate(new Vector3(point.x, posy, point.z)*speed*Time.deltaTime);
    }
  
    private void FixedUpdate()
    {
        LookAwayFrom(Player.position);
        currentdist = Vector3.Distance(transform.position, Player.position);
        if (currentdist < 2)
        {
            posy += (currentdist / 50) * Time.deltaTime;
            speed -= Time.deltaTime;
        }
        else
        {
            if (posy > 0)
            {
                posy -= (currentdist / 2) * Time.deltaTime;
                if(speed< 0.0059f)
                {
                    speed += Time.deltaTime;
                }
            }
        }
    }
  
}
