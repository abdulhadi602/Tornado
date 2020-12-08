using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{




    private float approachSpeed = -1;

    public Transform target;

    public bool startFollowing;

    public float distance =50;

    public float rotationSpeed = 200;
    private void FixedUpdate()
    {
      
       

        if (startFollowing)
        {
           
            /**if(transform.position.z >-5 || transform.position.z <0)
            {
                approachSpeed = -approachSpeed;
            }**/
            //transform.Translate(new Vector3(target.transform.position.x, target.transform.position.y,-2) * Time.deltaTime * approachSpeed);
            //transform.position = (transform.position - target.position).normalized * distance + target.transform.position;
            transform.LookAt(target.transform);
            
            transform.RotateAround(new Vector3(target.position.x,target.position.y,-2), Vector3.forward, rotationSpeed * Time.deltaTime);

        }
    

        
    }






}
