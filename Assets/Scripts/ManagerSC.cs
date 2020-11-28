using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManagerSC : MonoBehaviour
{
    public GameObject RestartCanvas, LevelCompleteCanvas;
    public GameObject Circle;
    public GameObject SpringJoinObj;
    private SpringJoint2D joint;
    private void Start()
    {
        joint = SpringJoinObj.GetComponent<SpringJoint2D>();
        Time.timeScale = 1;
        RestartCanvas.SetActive(false);
        LevelCompleteCanvas.SetActive(false);
        Circle.SetActive(true);


    }
    public void GameOver()
    {
        if (!RestartCanvas.activeSelf)
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
            Circle.SetActive(false);
            Time.timeScale = 0.75f;
            joint.connectedBody = null;
            LevelCompleteCanvas.SetActive(true);
        }
    }
    public void Restart()
    {
   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
