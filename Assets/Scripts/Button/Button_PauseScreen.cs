using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_PauseScreen : MonoBehaviour
{
    public GameObject pauseMenu;
    public void Resume()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
