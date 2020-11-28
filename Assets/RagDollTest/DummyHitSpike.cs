using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyHitSpike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Spike"))
        {
            
            GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerSC>().GameOver();

        }
    }
 
}
