using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Omar y Nad*/

public class Esc_b : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume() 
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
}
