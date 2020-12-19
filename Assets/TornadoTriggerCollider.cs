using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoTriggerCollider : MonoBehaviour
{
    public Transform target;
   
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Dummy"))
        {
            hit.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y+ 1,  hit.transform.position.z);
            hit.transform.parent = transform;
            
            hit.GetComponent<AI>().enabled = false;
            hit.GetComponent<Oscillator>().target = target;
            hit.GetComponent<Animator>().enabled = false;
            hit.GetComponent<Oscillator>().enabled = true;


        }
    }
}
