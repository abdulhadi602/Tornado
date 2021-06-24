using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchWithJoyStick : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public Transform Tornado;
    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = SimpleInput.GetAxis("Vertical") * speed;
        float rotation = SimpleInput.GetAxis("Horizontal") * rotationSpeed;
       
        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        Tornado.Translate(0, 0, translation);

        // Rotate around our y-axis
        Tornado.Rotate(0, rotation, 0);
    }
}
