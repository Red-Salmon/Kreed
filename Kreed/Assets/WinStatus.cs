using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinStatus : MonoBehaviour
{
    public bool FinalStatus;
    public bool VictoryStatus;
    public GameObject VictoryPanel;
    public TextMeshProUGUI VictoryText;

    void FixedUpdate()
    {
        if (FinalStatus)
        {
            VictoryText.GetComponent<TextMeshProUGUI>();
            if (VictoryStatus)
            {
                victory();
            }
            else
            {
                defeat();
            }
        }
    }

    void victory()
    {
        VictoryPanel.SetActive(true);
        TextMeshPro VictoryText = GetComponent<TextMeshPro>();
        VictoryText.SetText("Victory!");
    }
    
    void defeat()
    {
        VictoryPanel.SetActive(true);
        TextMeshPro VictoryText = GetComponent<TextMeshPro>();
        VictoryText.SetText("Defeat!");
    }
}
