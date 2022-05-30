using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static PauseMenu instance;
    public GameObject pauseScreen;
    public bool isPaused;
    public string levelSelect, mainMenu;
    
    void Awake()
    {
        instance = this;
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Menu"))
        {
            PauseUnPause();
        }
    }

    public void PauseUnPause()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
        }
        else
        {
            isPaused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
        Time.timeScale = 1f;
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
        Time.timeScale = 1f;
    }
}