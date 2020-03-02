using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : UnityEngine.MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public void Start () {

        pauseMenuUI.SetActive(false);
        Resume();
    }

   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; //Puedes relentizar el tiempo del juego(0.f-1.f)
        GameIsPaused = false;
    }

   public void Pause()
    {
        pauseMenuUI.SetActive (true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    } public void Quit()
    {
        Application.Quit();
    }
}
