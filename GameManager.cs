using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;




    // Start is called before the first frame update
    void Start()
    {
        _sessionStartTime = DateTime.Now;
        Debug.Log("Game session start: "+DateTime.Now);

        
    }

    private void OnApplicationQuit()
    {
        _sessionEndTime= DateTime.Now;

        TimeSpan timeDifference = 
            _sessionEndTime.Subtract(_sessionStartTime);

        Debug.Log("Game session ended: " + DateTime.Now);
        Debug.Log("Game session lasted: " + timeDifference);

    }

  public void playScene()
    {
        SceneManager.LoadScene("Playground");  
    }

    public void quitGame()
    {
        Application.Quit();
    }



}
