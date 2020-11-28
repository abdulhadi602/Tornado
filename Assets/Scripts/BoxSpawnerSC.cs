using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawnerSC : MonoBehaviour
{
    public GameObject Box;
    private GameObject currentBox;
    public GameObject Tornado;
    private FollowFinger fingerSC;
    private FollowBox FollowBoxSC;
    void Start()
    {
        fingerSC = Tornado.GetComponent<FollowFinger>();
        FollowBoxSC = Camera.main.GetComponent<FollowBox>();
        InstantiateNewBox();
        
    }

   public void InstantiateNewBox()
    {
        fingerSC.ResetPosition();
        currentBox = GameObject.Instantiate(Box, transform.position, Quaternion.identity);
        FollowBoxSC.SetNewInstance(currentBox.transform);
    }
}
