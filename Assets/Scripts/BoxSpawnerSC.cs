using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawnerSC : MonoBehaviour
{
    public GameObject Box;
    private GameObject currentBox;
    private GameObject Tornado;
    private FollowFinger fingerSC;
    private FollowBox FollowBoxSC;
    void Start()
    {
        Tornado = GameObject.FindGameObjectWithTag("Player");
        fingerSC = Tornado.GetComponent<FollowFinger>();
        FollowBoxSC = Camera.main.GetComponent<FollowBox>();
        InstantiateNewBox();
        
    }

   public void InstantiateNewBox()
    {
       
        currentBox = GameObject.Instantiate(Box, transform.position, Quaternion.identity);
        FollowBoxSC.SetNewInstance(currentBox.transform);
    }
}
