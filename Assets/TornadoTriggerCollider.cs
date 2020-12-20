using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoTriggerCollider : MonoBehaviour
{
    public Transform target;
   
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Dummy") && tag.Equals("Player"))
        {
            hit.transform.parent = transform;
           
            hit.transform.position = new Vector3(hit.transform.position.x,  Random.Range(2, 4), hit.transform.position.z+Random.Range(0,2));
            hit.GetComponent<AI>().enabled = false;
            hit.GetComponent<Oscillator>().target = target;
            hit.GetComponent<Animator>().enabled = false;
            hit.GetComponent<Oscillator>().enabled = true;


        }
    }
}
