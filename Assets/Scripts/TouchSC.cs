using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSC : MonoBehaviour
{

    // touch offset allows ball not to shake when it starts moving

    float deltaX, deltaY;


    // reference to Rigidbody2D component

    public Transform Tornado;

    // Update is called once per frame

    private Vector2 lastTornadoPos;

    public static bool TouchEnabled;

    void Update()
    {
        // Initiating touch event

        // if touch event takes place


        if (TouchEnabled && Input.touchCount > 0)
        {


            // get touch position

            Touch touch = Input.GetTouch(0);

            // obtain touch position

            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);


            // get touch to take a deal with

            switch (touch.phase)
            {

                // if you touches the screen

                case TouchPhase.Began:



                    //Touch.gameObject.SetActive(true);
                    if (lastTornadoPos.x - touchPos.x < 2 && lastTornadoPos.x - touchPos.x > -2 && lastTornadoPos.y - touchPos.y < 2 && lastTornadoPos.y - touchPos.y > -2)
                    {
                        Tornado.position = touchPos;
                    }
                    else
                    {
                        Tornado.GetChild(1).gameObject.GetComponent<SpringJoint2D>().connectedBody = null;
                    }


                  break;


                // you move your finger

                case TouchPhase.Moved:

                    // if you touches the ball and movement is allowed then move



                    if (lastTornadoPos.x - touchPos.x < 2 && lastTornadoPos.x - touchPos.x > -2 && lastTornadoPos.y - touchPos.y < 4 && lastTornadoPos.y - touchPos.y > -4)
                    {
                        
                        Tornado.position = touchPos;
                    }
                    else
                    {
                   
                        Tornado.GetChild(1).gameObject.GetComponent<SpringJoint2D>().connectedBody = null;
                    }

                    break;


                // you release your finger

                case TouchPhase.Ended:



                   // Touch.gameObject.SetActive(false);

                    break;

            }
            lastTornadoPos = Tornado.position;
        }
        

    }
}
