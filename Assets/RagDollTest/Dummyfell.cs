using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummyfell : MonoBehaviour
{
    
    void Update()
    {
        if (transform.position.y < -7.5f)
        {
            GameObject.FindGameObjectWithTag("Manager").GetComponent<ManagerSC>().GameOver();
        }
    }
}
