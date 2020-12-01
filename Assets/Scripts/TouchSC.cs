using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSC : MonoBehaviour
{

    // touch offset allows ball not to shake when it starts moving

    float deltaX, deltaY;


    // reference to Rigidbody2D component

    private Transform Tornado;




    // Update is called once per frame

    private Vector2 lastTornadoPos;

    public static bool TouchEnabled;



    private Vector3 desiredPosition;
    private Vector3 smoothedPosition;
    public float smoothSpeed = 0.125f;


    private void Start()
    {
        Tornado = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Initiating touch event

        // if touch event takes place


        if (TouchEnabled && Input.touchCount > 0)
        {


            // get touch position

            Touch touch = Input.GetTouch(0);

            // obtain touch position

            Vector2 touchPos = GetWorldPositionOnPlane(touch.position,0);


            // get touch to take a deal with

            switch (touch.phase)
            {

                // if you touches the screen

                case TouchPhase.Began:



                    //Touch.gameObject.SetActive(true);
                    if (lastTornadoPos.x - touchPos.x < 1 && lastTornadoPos.x - touchPos.x > -1 && lastTornadoPos.y - touchPos.y < 1 && lastTornadoPos.y - touchPos.y > -1)
                    {
                        desiredPosition = touchPos;
                        Tornado.transform.GetChild(2).gameObject.SetActive(false);
                      
                    }
                    
                  


                  break;


                // you move your finger

                case TouchPhase.Moved:

                    // if you touches the ball and movement is allowed then move




                    
                        Tornado.transform.GetChild(2).gameObject.SetActive(false);
                        desiredPosition = touchPos;

                    
                    
                   

                    break;


                // you release your finger

                case TouchPhase.Ended:



                    // Touch.gameObject.SetActive(false);
                    Tornado.transform.GetChild(2).gameObject.SetActive(true);

                    break;

            }
            lastTornadoPos = Tornado.position;
        }
        

    }
    private void FixedUpdate()
    {
        smoothedPosition = Vector3.Lerp(Tornado.position, desiredPosition, smoothSpeed);
        Tornado.position = smoothedPosition;
    }
    public Vector3 GetWorldPositionOnPlane(Vector3 screenPosition, float z)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPosition);
        Plane xy = new Plane(Vector3.forward, new Vector3(0, 0, z));
        float distance;
        xy.Raycast(ray, out distance);
        return ray.GetPoint(distance);
    }
}
