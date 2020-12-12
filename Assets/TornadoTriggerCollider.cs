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
          
            hit.GetComponent<Oscillator>().target = this.target;
        }
    }
}
