using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnHandlerScript : MonoBehaviour
{
    public int turnCount;
    private int inDelay;

    public TMPro.TextMeshProUGUI topDisplay;

    void Awake()
    {
        turnCount = 1;
        inDelay = 3;
    }

    private void Start()
    {
        StartCoroutine("Turn1");
    }

    void Update()
    {
        
    }

    IEnumerator Turn1()
    {
        topDisplay.text = "Enemy Turn";
        yield return new WaitForSeconds(inDelay);
        topDisplay.text = "Enemy does 50 damage to the player";
        yield return new WaitForSeconds(inDelay);
        topDisplay.text = "Enemy is charging up for his final attack. Defeat the enemy before he attacks again.";
        yield return new WaitForSeconds(inDelay * 1.5f);
        topDisplay.text = "Your Turn";
    }
}
