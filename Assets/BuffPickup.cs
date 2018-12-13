using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffPickup : MonoBehaviour
{
    public PlayerAbilities.Buff.Type buff;
    public float amount;
    public float time;

    public PlayerAbilities abilities;
    
    public void AddBuff()
    {
        abilities.AddBuff(buff, amount, time);
    }
}
