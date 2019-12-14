using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    void Start()
    {
        pausePanel.SetActive(false);
    }
 
    public void PauseThis() 
    {
        Debug.Log("Masuk");
        if (!pausePanel.activeInHierarchy)
        {
            Debug.Log("Masuk Pause");
            PauseGame();
        }
        else if (pausePanel.activeInHierarchy)
        {
            Debug.Log("Masuk UnPause");
            ContinueGame();
        }
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    }
    private void ContinueGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        //enable the scripts again
    }
}
