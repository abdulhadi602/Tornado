using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class isGameOver : MonoBehaviour
{
    private GameObject BoxSpawner;
    private BoxSpawnerSC spawner;
    private bool isEnabled;

    private GameObject Score;
    private ScoreSC scoreSC;


    private GameObject Player;
 

  
    private void Start()
    {
        
        Player = GameObject.FindGameObjectWithTag("Player");
        Score = GameObject.FindGameObjectWithTag("Score");
        scoreSC = Score.GetComponent<ScoreSC>();
        isEnabled = true;
        BoxSpawner = GameObject.FindGameObjectWithTag("BoxSpawner");
        spawner = BoxSpawner.GetComponent<BoxSpawnerSC>();
    }
    void Update()
    {
        if ( transform.position.y<-7.5f)
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerSC>().GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
        
            GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerSC>().GameOver();
          
        }
    }
    /**private void OnCollisionStay2D(Collision2D collision)
    {
        if (isEnabled)
        {
            ScoreSC.UpdateScore();
            spawner.InstantiateNewBox();
            isEnabled = false;
        }
    }**/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isEnabled)
        {
            // Raycasting to determine what side of the brick the ball hits
            Ray myRay = new Ray(transform.position, collision.gameObject.transform.position);
            RaycastHit myRayHit;

            Physics.Raycast(myRay, out myRayHit);
            Vector2 hit = collision.contacts[0].normal;
            // Debug.Log("Hit  " + hit);
            float angle = Vector3.Angle(Vector2.right, hit);
            Debug.DrawRay(transform.position, collision.gameObject.transform.position, Color.red);

            // Debug.Log("Angle  " +angle);
            if (Mathf.Approximately(angle, 0))// Left
            {
                Debug.Log("Left");
            }
            if (Mathf.Approximately(angle, 180))// Right
            {
                Debug.Log("Right");
            }
            if (Mathf.Approximately(angle, 90))
            {
                Vector3 cross = Vector3.Cross(Vector2.right, hit);
                Debug.Log("Cross " + cross);
                if (cross.z > 0)
                {
                    //Camera.main.orthographicSize += 1;
                    //Camera.main.GetComponent<CameraScale>().UpdateScale(Camera.main.orthographicSize);
                    if (collision.collider.CompareTag("Base") || collision.collider.CompareTag("Box"))
                    {
                        GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerSC>().GameOver();
                        /**TouchSC.TouchEnabled = false;
                        Player.transform.GetChild(0).gameObject.SetActive(false);
                        Player.transform.GetChild(1).gameObject.GetComponent<SpringJoint2D>().connectedBody = null;
                        scoreSC.UpdateScore();
                        spawner.InstantiateNewBox();
                        isEnabled = false;**/
                    }
                }
                else
                {

                    Debug.Log("tOP");

                }

            }
        }
    }
}
