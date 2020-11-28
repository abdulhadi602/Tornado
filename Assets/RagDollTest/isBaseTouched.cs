using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isBaseTouched : MonoBehaviour
{

   

    private void OnCollisionEnter2D(Collision2D collision)
    {               
                if (collision.collider.CompareTag("Dummy"))
                {
                   
                    GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerSC>().LevelCompleted();
                }                                          
    }
}
