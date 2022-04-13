using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostMenu : MonoBehaviour
{
    public GameObject pauseScreen;
    public bool isPaused;
    public string levelSelect, mainMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
