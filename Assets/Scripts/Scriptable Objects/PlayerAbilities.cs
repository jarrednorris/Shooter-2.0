using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Player Abilities")]
public class PlayerAbilities : ScriptableObject
{
    public Buff speedBuff, damageBuff, shootBuff;

    private void OnEnable()
    {
        Reset();
    }

    public void Reset()
    {
        speedBuff.Reset();
        damageBuff.Reset();
        shootBuff.Reset();
    }

    public void AddBuff(Buff.Type buff, float amount, float time)
    {
        Buff buffVar = null;
        switch (buff)
        {
            case Buff.Type.Speed:
                buffVar = speedBuff;
                break;
            case Buff.Type.Damage:
                buffVar = damageBuff;
                break;
            case Buff.Type.Shoot:
                buffVar = shootBuff;
                break;
        }
        buffVar.amount = amount;
        buffVar.timeRemaining = time;
    }

    [System.Serializable]
    public class Buff
    {
        public float timeRemaining, amount;
        public enum Type { Speed, Damage, Shoot }

        public void Reset()
        {
            timeRemaining = 0;
            amount = 0;
        }
    }
}