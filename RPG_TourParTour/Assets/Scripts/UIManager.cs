using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private bool OnPause;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }

    private void Pause()
    {
        if (OnPause)
        {
            //pausePanel.SetActive(true);
        }
        else
        {
            //pausePanel.SetActive(false);
        }
    }

    private void Play()
    {
        SceneManager.LoadScene("Map");
    }

    private void Quit()
    {
        Application.Quit();
    }
}
