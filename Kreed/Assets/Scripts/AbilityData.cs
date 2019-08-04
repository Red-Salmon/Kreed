using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityData : MonoBehaviour
{
    public TMPro.TextMeshProUGUI dis1;
    public TMPro.TextMeshProUGUI dis2;
    public TMPro.TextMeshProUGUI dis3;
    public TMPro.TextMeshProUGUI dis4;
    public TMPro.TextMeshProUGUI dis5;

    void Start() {
        dis1.text = AbilityName(PlayerPrefs.GetInt("ab1"));
        dis2.text = AbilityName(PlayerPrefs.GetInt("ab2"));
        dis3.text = AbilityName(PlayerPrefs.GetInt("ab3"));
        dis4.text = AbilityName(PlayerPrefs.GetInt("ab4"));
        dis5.text = AbilityName(PlayerPrefs.GetInt("ab5"));
    }

    private string AbilityName(int x)
    {
        switch (x)
        {
            case 1:
                return "Ignius";
                break;
            case 2:
                return "Scorch";
                break;
            case 3:
                return "Ashes";
                break;
            case 4:
                return "Scald";
                break;
            case 5:
                return "Freeze";
                break;
            case 6:
                return "Tsunami";
                break;
            case 7:
                return "Curse";
                break;
            case 8:
                return "Leech";
                break;
            case 9:
                return "Soul Slice";
                break;
            case 10:
                return "Aura Guard";
                break;
            case 11:
                return "Earth Guard";
                break;
            case 12:
                return "Mirror Guard";
                break;
            case 13:
                return "Elixir";
                break;
            case 14:
                return "Battle Stance";
                break;
            default:
                return x.ToString();
                break;
        }
    }
}
