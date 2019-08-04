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

    public int turnCount;
    private int inDelay;

    public Button abilityButton1;
    public Button abilityButton2;
    public Button abilityButton3;
    public Button abilityButton4;
    public Button abilityButton5;

    public CharacterStats player1;
    public CharacterStats enemyStats;

    public TMPro.TextMeshProUGUI topDisplay;

    void Awake()
    {
        turnCount = 1;
        inDelay = 3;

    }

    void Start()
    {
        dis1.text = AbilityName(PlayerPrefs.GetInt("ab1"));
        dis2.text = AbilityName(PlayerPrefs.GetInt("ab2"));
        dis3.text = AbilityName(PlayerPrefs.GetInt("ab3"));
        dis4.text = AbilityName(PlayerPrefs.GetInt("ab4"));
        dis5.text = AbilityName(PlayerPrefs.GetInt("ab5"));

        // Triggering passive abilities
        if (PlayerPrefs.GetInt("ab1") >= 10)
        {
            ActivateAbility(PlayerPrefs.GetInt("ab1"));
            abilityButton1.interactable = false;
        }
        if (PlayerPrefs.GetInt("ab2") >= 10)
        {
            ActivateAbility(PlayerPrefs.GetInt("ab2"));
            abilityButton2.interactable = false;
        }
        if (PlayerPrefs.GetInt("ab3") >= 10)
        {
            ActivateAbility(PlayerPrefs.GetInt("ab3"));
            abilityButton3.interactable = false;
        }
        if (PlayerPrefs.GetInt("ab4") >= 10)
        {
            ActivateAbility(PlayerPrefs.GetInt("ab4"));
            abilityButton4.interactable = false;
        }
        if (PlayerPrefs.GetInt("ab5") >= 10)
        {
            ActivateAbility(PlayerPrefs.GetInt("ab5"));
            abilityButton1.interactable = false;
        }

        // Starting the enemy's attack
        StartCoroutine("Turn1");
    }

    void Update()
    {
        CheckDefeat();
        CheckVictory();
    }

    IEnumerator Turn1()
    {
        topDisplay.text = "Enemy Turn";
        yield return new WaitForSeconds(inDelay);
        topDisplay.text = "Enemy does 50 damage to the player";
        if (initialResist >= 0)
        {
            player1.TakePhyDamage(50 * ((100 - initialResist) / 100));
        } else
        {
            enemyStats.TakePhyDamage(50);
        }

        if (player1.IsAlive())
        {
            yield return new WaitForSeconds(inDelay);
            topDisplay.text = "Enemy is charging up for his final attack. Defeat the enemy before he attacks again.";
            yield return new WaitForSeconds(inDelay * 1.5f);
            topDisplay.text = "Your Turn";

            abilityButton1.interactable = true;
            abilityButton2.interactable = true;
            abilityButton3.interactable = true;
            abilityButton4.interactable = true;
            abilityButton5.interactable = true;
            turnCount++;
        }
        else
        {
            yield return new WaitForSeconds(inDelay);
            topDisplay.text = "The enemy has killed the player in the first attack.";
            Debug.Log("Game Over!");
        }

        // Incase all four of the player's abilities are passives
        TurnEnd();
    }

    private void CheckVictory()
    {
        //topDisplay.text = "The player has slayed the Hydra.";
    }

    private void CheckDefeat()
    {
        //topDisplay.text = "The player has been defeated.";
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

    //public void AbilityDescription(int x)
    //{
    //    switch (x)
    //    {
    //        case 1:
    //            //abilityDetails.text = "Deals 10 fire damage";
    //            break;
    //        case 2:
    //            //abilityDetails.text = "Deal 10 fire damage, if enemy was attacked with fire damage, double this damage";
    //            break;
    //        case 3:
    //            //abilityDetails.text = "Deals 30 fire damage";
    //            break;
    //        case 4:
    //            //abilityDetails.text = "Deal 10 water damage, enemy takes 50% more damage from fire damage for 1 turn ";
    //            break;
    //        case 5:
    //            //abilityDetails.text = "Deal 15 water damage, if enemy was attacked with fire damage, triple this damage";
    //            break;
    //        case 6:
    //            //abilityDetails.text = "Deal 50 water damge";
    //            break;
    //        case 7:
    //            //abilityDetails.text = "The enemy has been tagged as cursed";
    //            break;
    //        case 8:
    //            //abilityDetails.text = "Half the HP of a cursed enemy";
    //            break;
    //        case 9:
    //            //abilityDetails.text = "One third the HP of a cursed enemy";
    //            break;
    //        case 10:
    //            //abilityDetails.text = "Nullify all damage";
    //            break;
    //        case 11:
    //            //abilityDetails.text = "Half the damage taken";
    //            break;
    //        case 12:
    //            //abilityDetails.text = "Reflect the damage taken back to the monster";
    //            break;
    //        case 13:
    //            //abilityDetails.text = "Gives you +100 health before battle";
    //            break;
    //        case 14:
    //            //abilityDetails.text = "All your attacks deal double damage";
    //            break;
    //        default:
    //            //abilityDetails.text = "";
    //            break;
    //    }
    //}

    public void ActivateAbil1()
    {
        ActivateAbility(PlayerPrefs.GetInt("ab1"));
        abilityButton1.interactable = false;
        TurnEnd(); //check if all abilities have been used
    }

    public void ActivateAbil2()
    {
        ActivateAbility(PlayerPrefs.GetInt("ab2"));
        abilityButton2.interactable = false;
        TurnEnd(); //check if all abilities have been used
    }

    public void ActivateAbil3()
    {
        ActivateAbility(PlayerPrefs.GetInt("ab3"));
        abilityButton3.interactable = false;
        TurnEnd(); //check if all abilities have been used
    }

    public void ActivateAbil4()
    {
        ActivateAbility(PlayerPrefs.GetInt("ab4"));
        abilityButton4.interactable = false;
        TurnEnd(); //check if all abilities have been used
    }

    public void ActivateAbil5()
    {
        ActivateAbility(PlayerPrefs.GetInt("ab5"));
        abilityButton5.interactable = false;
        TurnEnd(); //check if all abilities have been used
    }

    //Ability Specific variables
    private int fireBuff = 1;
    private int initialResist = 0;

    private void ActivateAbility(int x)
    {
        switch (x)
        {
            case 1:
                //return "Ignius";
                enemyStats.TakePhyDamage(10 * (1 + player1.percentBuff / 100) * fireBuff);
                enemyStats.burning = true;
                break;
            case 2:
                //return "Scorch";
                if (enemyStats.burning)
                {
                    enemyStats.TakePhyDamage(40 * (1 + player1.percentBuff / 100) * fireBuff);
                } else
                {
                    enemyStats.TakePhyDamage(20 * (1 + player1.percentBuff / 100) * fireBuff);
                }
                enemyStats.burning = true;
                break;
            case 3:
                //return "Ashes";
                enemyStats.TakePhyDamage(30 * (1 + player1.percentBuff / 100) * fireBuff);
                enemyStats.burning = true;
                break;
            case 4:
                //return "Scald";
                fireBuff = 2;
                enemyStats.TakePhyDamage(10 * (1 + player1.percentBuff / 100));
                enemyStats.wet = true;
                break;
            case 5:
                //return "Freeze";
                if (enemyStats.wet)
                {
                    enemyStats.TakePhyDamage(45 * (1 + player1.percentBuff / 100));
                }
                else
                {
                    enemyStats.TakePhyDamage(15 * (1 + player1.percentBuff / 100));
                }
                enemyStats.wet = true;
                break;
            case 6:
                //return "Tsunami";
                enemyStats.TakePhyDamage(50 * (1 + player1.percentBuff / 100));
                enemyStats.wet = true;
                break;
            case 7:
                //return "Curse";
                enemyStats.cursed = true;
                break;
            case 8:
                //return "Leech";
                if (enemyStats.cursed)
                {
                    enemyStats.currentHealth = Mathf.Ceil(enemyStats.currentHealth / 2);
                }
                break;
            case 9:
                //return "Soul Slice";
                if (enemyStats.cursed)
                {
                    enemyStats.currentHealth = Mathf.Ceil(enemyStats.currentHealth / 3);
                }
                break;
            case 10:
                //return "Aura guard";
                initialResist = 100;
                break;
            case 11:
                //return "Earth guard";
                initialResist = 50;
                break;
            case 12:
                //return "mirror guard";
                initialResist = -100;
                break;
            case 13:
                //return "elixir";
                player1.currentHealth += 100;
                break;
            case 14:
                //return "stance";
                player1.percentBuff = 100;
                break;
            default:
                break;
        }
    }

    private void TurnEnd()
    {
        if (!(abilityButton1.interactable | abilityButton2.interactable | abilityButton3.interactable | abilityButton4.interactable | abilityButton5.interactable))
        {
            Debug.Log("Turn is over!");
            turnCount++;
            StartCoroutine("Turn3");
        }
    }

    IEnumerator Turn3()
    {
        topDisplay.text = "Your Turn is over!";
        yield return new WaitForSeconds(inDelay);
        if (enemyStats.IsAlive())
        {
            topDisplay.text = "Enemy deals 10,000,000 damage to the player.";
            player1.currentHealth = 0;
            yield return new WaitForSeconds(inDelay);
            topDisplay.text = "The player has been defeated.";
            yield return new WaitForSeconds(inDelay);
            topDisplay.text = "Press Escape to retry";
        } else
        {
            topDisplay.text = "Congratulations! You have slain the Hydra.";
            yield return new WaitForSeconds(inDelay);
            topDisplay.text = "No more monsters currently available for battle in this prototype. Press Escape to replay.";
        }
    }
}
