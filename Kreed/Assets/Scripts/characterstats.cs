using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    // Health
    public float maxHealth;
    public float currentHealth;

    // Buffs and resistances
    public float percentResist;
    public float percentBuff;

    // Status Effects
    public bool cursed;
    public bool burning;
    public bool wet;

    public TMPro.TextMeshProUGUI display;

    void Awake()
    {
        currentHealth = maxHealth;
        percentBuff = 0;

        cursed = false;
        burning = false;
        wet = false;
    }

    
    void Update()
    {
        display.text = currentHealth + "/" + maxHealth;
    }

    //This procedure will check if the character is still alive
    public bool IsAlive()
    {
        if (currentHealth <= 0)
        {
            return false;
        } else
        {
            return true;
        }
    }

    // We will not reduce the health of the character directly.
    // This method will be used so that we dont have to check the resistance every time
    public void TakePhyDamage(float damage)
    {
        currentHealth -= ((100 - percentResist)/100) * damage;
        if (currentHealth < 0) { currentHealth = 0; }
    }

    
    //public void HealUp(float heal)
    //{
    //    if (currentHealth > 0 & currentHealth < maxHealth)
    //    {
    //        currentHealth += heal;
    //        if (currentHealth > maxHealth) { currentHealth = maxHealth; }
    //    }
    //}
}
