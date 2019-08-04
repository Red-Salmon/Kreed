using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public int totalAbil;
    public Button startLevel;

    public void Awake()
    {
        startLevel.interactable = false;
    }

    public void LoadLevel()
    {
        PlayerPrefs.SetInt("ab1", 1);
        PlayerPrefs.SetInt("ab2", 2);
        PlayerPrefs.SetInt("ab3", 4);
        PlayerPrefs.SetInt("ab4", 8);
        PlayerPrefs.SetInt("ab5", 14);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectAbil()
    {
        totalAbil++;
        if (totalAbil >= 5)
        {
            startLevel.interactable = true;
        }
    }
}
