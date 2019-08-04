using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject BattlePanelUI;
    //name of the main menu (if name changed or a different menu is created, change the string in the unity developer)
    public string Menu;

    void Update()
    {
        //if button 'Esc' is hit, the game is paused or resumed depending on the current status
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            { 
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //loads the menu
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Menu);
    }

    //feature might be removed (considering it's going to be a flashgame on itch.io)
    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Application.Quit();

    }

    public void Resume ()
    {
        PauseMenuUI.SetActive(false);
        //reactivates the battle panel, to undo it's deactivation
        BattlePanelUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause ()
    {
        PauseMenuUI.SetActive(true);
        //deactivates the battle panel, to make pause more obvious
        BattlePanelUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
