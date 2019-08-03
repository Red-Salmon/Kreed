using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadLevel()
    {
        //public TMPro.TextMeshProUGUI abil1;

        //GlobalVariables.abil1 = abil1.text;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
