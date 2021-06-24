using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DebugSC : MonoBehaviour
{
    public Text testtxt;
  

    // Update is called once per frame
    void Update()
    {
        testtxt.text = transform.position.ToString(); 
    }
}
