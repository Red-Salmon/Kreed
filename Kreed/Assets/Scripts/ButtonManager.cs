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

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SelectAbil()
    {
        //private GameObject global1;
        //global1.SaveData.x = 5;

    }
}
