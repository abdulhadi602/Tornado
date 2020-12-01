using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFinger : MonoBehaviour
{
    public float force;
    private Vector2 position;




    private static SpringJoint2D Spring;
    private GameObject currentBox;


 

    private void Start()
    {
       
        Spring = transform.GetChild(1).gameObject.GetComponent<SpringJoint2D>();
        position = new Vector2(0, 2f);

    }
    public void ResetPosition()
    {
       
        transform.position = position;
       
    }
    void FixedUpdate()
    {
        // Cast a ray straight down.
       
        RaycastHit2D hit = Physics2D.Raycast(transform.GetChild(0).position, Vector2.up,2);
        if (hit.collider != null && hit.collider.CompareTag("Dummy"))
        {
            if(currentBox != hit.collider.gameObject)
            currentBox = hit.collider.gameObject;
            Spring.connectedBody = currentBox.GetComponent<Rigidbody2D>();

        }
        else if(currentBox != null && (transform.GetChild(0).position.y - 4 > currentBox.transform.position.y ||  currentBox.transform.position.y > transform.GetChild(1).position.y +1 || currentBox.transform.position.x > transform.GetChild(1).position.x+4 || currentBox.transform.position.x < transform.GetChild(1).position.x - 4))
        {

            FollowFinger.DetachBody();
           
           
        }

        
        /** RaycastHit2D data = Physics2D.BoxCast(transform.position, Vector2.one, 0, Vector2.up, 4.5f);
         if (data.collider != null && data.collider.CompareTag("Box"))
         {
             
             Vector3 direction = data.transform.position - transform.position;
             data.collider.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(direction.normalized * force, data.point, ForceMode2D.Force);
         }**/
        // If it hits something...
        /**if (hit.collider != null && hit.collider.CompareTag("Box"))
        {
            Vector3 direction = hit.transform.position - transform.position;
         

           

            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(direction.normalized * force, hit.point, ForceMode2D.Force);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(direction.normalized * force, new Vector2(hit.point.x+1,hit.point.y), ForceMode2D.Force);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(direction.normalized * force, new Vector2(hit.point.x -1 , hit.point.y), ForceMode2D.Force);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(direction.normalized * force, new Vector2(hit.point.x + 2, hit.point.y), ForceMode2D.Force);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(direction.normalized * force, new Vector2(hit.point.x - 2, hit.point.y), ForceMode2D.Force);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(direction.normalized * force, new Vector2(hit.point.x + 1, hit.point.y), ForceMode2D.Force);
            hit.collider.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(direction.normalized * force, new Vector2(hit.point.x - 1, hit.point.y), ForceMode2D.Force);

        }**/
    }

    public static void DetachBody()
    {
        Spring.connectedBody = null;
        
    }
    
    
}
