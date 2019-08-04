using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public void LoadLevel()
    {
        //public TMPro.TextMeshProUGUI abil1;

        //GlobalVariables.abil1 = abil1.text;
        PlayerPrefs.SetInt("ab1", 1);
        PlayerPrefs.SetInt("ab2", 2);
        PlayerPrefs.SetInt("ab3", 4);
        PlayerPrefs.SetInt("ab4", 8);
        PlayerPrefs.SetInt("ab5", 14);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectAbil()
    {
        //public AbilityData coor1;
    }
}
