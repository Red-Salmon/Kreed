using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Battler : MonoBehaviour,IComparable<Battler>
{
    public int speed = 5;
    public int delay = 1;
    public string title = "NONE";
    public BattleCommand chosenCommand;
    public BattleCommand testCommand;



    public abstract IEnumerator decideTurn();

    public IEnumerator executeTurn()
    {
        if (chosenCommand != null)
            yield return StartCoroutine(testCommand.execute());
        chosenCommand = null;
    }

    public int CompareTo(Battler other)
    {
        if ((delay - speed) != (other.delay - other.speed))
            return (delay - speed) - (other.delay - other.speed);
        return other.speed - speed;
    }
}
