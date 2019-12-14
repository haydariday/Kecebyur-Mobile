using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    float m_LastPressTime;
    float m_PressDelay = 0.5f;
    public void StartFirstLevel()
    {
        /*if (m_LastPressTime + m_PressDelay > Time.unscaledTime)
            return;
        m_LastPressTime = Time.unscaledTime;*/
/*        new WaitForSeconds(10f);*/
        SceneManager.LoadScene(1);
    }
/*
    IEnumerator ButtonDelay()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(10f);
        Debug.Log(Time.time);

        // This line will be executed after 10 seconds passed
        Button2.gameObject.SetActive(true);
    }*/
}
