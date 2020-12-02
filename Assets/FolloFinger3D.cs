using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloFinger3D : MonoBehaviour
{
    
    




    private static SpringJoint Spring;
    private GameObject currentBox;




    private void Start()
    {

        Spring = transform.GetChild(1).gameObject.GetComponent<SpringJoint>();
    

    }
  
    void FixedUpdate()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, Vector3.up, out hit);
        
        if (hit.collider != null && hit.collider.CompareTag("Dummy"))
        {
            if (currentBox != hit.collider.gameObject)
                currentBox = hit.collider.gameObject;
            Spring.connectedBody = currentBox.GetComponent<Rigidbody>();

        }
        /**else if (currentBox != null && (transform.GetChild(0).position.y - 4 > currentBox.transform.position.y || currentBox.transform.position.y > transform.GetChild(1).position.y + 1 || currentBox.transform.position.x > transform.GetChild(1).position.x + 4 || currentBox.transform.position.x < transform.GetChild(1).position.x - 4))
        {

            DetachBody();


        }**/


     
    }

    public static void DetachBody()
    {
        Spring.connectedBody = null;

    }

}
