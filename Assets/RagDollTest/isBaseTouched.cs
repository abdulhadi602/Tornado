using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isBaseTouched : MonoBehaviour
{

    public GameObject Animation;
    private static bool isLevelOver = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {               
                if (collision.collider.CompareTag("Dummy") && !isLevelOver)
                {
                    isLevelOver = true;  
                    GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerSC>().LevelCompleted();
                    if(collision.transform.parent != null)
                     {
                     collision.transform.parent.gameObject.SetActive(false);
            }
            else
            {
                collision.gameObject.SetActive(false);
            }   
            Instantiate(Animation, new Vector3(collision.transform.position.x, transform.position.y + 0.5f, collision.transform.position.z), Quaternion.Euler(0,0,90));

                }                                          
    }
}
