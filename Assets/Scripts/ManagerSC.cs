using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManagerSC : MonoBehaviour
{
    public GameObject RestartCanvas, LevelCompleteCanvas , GameStartCanvas;
    public GameObject Circle;
    public GameObject SpringJoinObj;
    private SpringJoint2D joint;

    public GameObject Touch;
    private void Start()
    {
        joint = SpringJoinObj.GetComponent<SpringJoint2D>();
        Time.timeScale = 1;
        GameStartCanvas.SetActive(true);
        RestartCanvas.SetActive(false);
        LevelCompleteCanvas.SetActive(false);
     
        Circle.SetActive(true);
        Touch.GetComponent<TouchSC>().enabled = false;


    }
    public void GameOver()
    {
        if (!RestartCanvas.activeSelf && !LevelCompleteCanvas.activeSelf)
        {
            SoundManager.PlayHit();
            Circle.SetActive(false);
            Time.timeScale = 0.5f;
            joint.connectedBody = null;
            RestartCanvas.SetActive(true);
        }
    }
    public void LevelCompleted()
    {
        if (!LevelCompleteCanvas.activeSelf)
        {
            SoundManager.PlayWin();
            Circle.SetActive(false);
            Time.timeScale = 0.75f;
            joint.connectedBody = null;
            LevelCompleteCanvas.SetActive(true);
        }
    }
    public void GameStart()
    {
        SoundManager.PlayWind();
        GameStartCanvas.SetActive(false);
     
        Touch.GetComponent<TouchSC>().enabled = true;
    }
    public void Restart()
    {
   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
