using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    public PlayerAbilities abilities;

    private void Update()
    {
        HandleAbility(ref abilities.shootBuff.timeRemaining, ref abilities.shootBuff.amount);
        HandleAbility(ref abilities.damageBuff.timeRemaining, ref abilities.damageBuff.amount);
        HandleAbility(ref abilities.speedBuff.timeRemaining, ref abilities.speedBuff.amount);
    }

    public void HandleAbility(ref float timeRemaining, ref float amount)
    {
        timeRemaining = Mathf.Clamp(timeRemaining - Time.deltaTime, 0, timeRemaining);
        if(timeRemaining == 0)
            amount = 0;
    }
}