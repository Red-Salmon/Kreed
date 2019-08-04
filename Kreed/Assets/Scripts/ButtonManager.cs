using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public int totalAbil;
    public TMPro.TextMeshProUGUI abilityDetails;
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

    public void ShowAbil(int x)
    {
        switch (x)
        {
            case 1:
                abilityDetails.text = "Deals 10 fire damage";
                break;
            case 2:
                abilityDetails.text = "Deal 10 fire damage, if enemy was attacked with fire damage, double this damage";
                break;
            case 3:
                abilityDetails.text = "Deals 30 fire damage";
                break;
            case 4:
                abilityDetails.text = "Deal 10 water damage, enemy takes 50% more damage from fire damage for 1 turn ";
                break;
            case 5:
                abilityDetails.text = "Deal 15 water damage, if enemy was attacked with fire damage, triple this damage";
                break;
            case 6:
                abilityDetails.text = "Deal 50 water damge";
                break;
            case 7:
                abilityDetails.text = "The enemy has been tagged as cursed";
                break;
            case 8:
                abilityDetails.text = "Half the HP of a cursed enemy";
                break;
            case 9:
                abilityDetails.text = "One third the HP of a cursed enemy";
                break;
            case 10:
                abilityDetails.text = "Nullify all damage";
                break;
            case 11:
                abilityDetails.text = "Half the damage taken";
                break;
            case 12:
                abilityDetails.text = "Reflect the damage taken back to the monster";
                break;
            case 13:
                abilityDetails.text = "Gives you +100 health before battle";
                break;
            case 14:
                abilityDetails.text = "All your attacks deal double damage";
                break;
            default:
                abilityDetails.text = "";
                break;
        }
    }
}
