using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloFinger3D : MonoBehaviour
{
    
    





    private GameObject[] currentBox;

    List<GameObject> items = new List<GameObject>();

    public Transform target;
  
    void FixedUpdate()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, Vector3.up, out hit);
        
        if (hit.collider != null && hit.collider.CompareTag("Dummy"))
        {
            /**if (items.Count > 0)
            {
                foreach (GameObject item in items)
                {
                    if (!item.Equals(hit.collider.gameObject))
                    {
                        hit.collider.GetComponent<Oscillator>().startFollowing = true;
                        hit.collider.GetComponent<Oscillator>().target = this.target;
                        items.Add(hit.collider.gameObject);

                    }
                }
            }
            else
            {**/
              
                hit.collider.GetComponent<Oscillator>().target = this.target;
               // items.Add(hit.collider.gameObject);
           // }

        }
        /**else if (currentBox != null && (transform.GetChild(0).position.y - 4 > currentBox.transform.position.y || currentBox.transform.position.y > transform.GetChild(1).position.y + 1 || currentBox.transform.position.x > transform.GetChild(1).position.x + 4 || currentBox.transform.position.x < transform.GetChild(1).position.x - 4))
        {

            DetachBody();


        }**/


     
    }

    public static void DetachBody(GameObject item)
    {
      
        

    }

}
