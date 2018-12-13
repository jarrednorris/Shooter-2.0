using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthComponent : MonoBehaviour
{
    public IntVariable intVariable;

    public int currentHealth;
    public int maxHealth = 20;
    public UnityEvent onHealthChanged, onDie;

    private void Awake()
    {
        ModifyHealth(maxHealth);
    }

    public void ModifyHealth(int amount)
    {
        if (intVariable != null)
            ModifyHealthIntVar(amount);
        else
            ModifyHealthStandard(amount);
    }

    private void ModifyHealthIntVar(int amount)
    {
        intVariable.RuntimeValue = (int)Mathf.Clamp(intVariable.RuntimeValue + amount, 0, maxHealth);
        currentHealth = intVariable.RuntimeValue;
        onHealthChanged.Invoke();
        if (currentHealth == 0)
            onDie.Invoke();
    }

    private void ModifyHealthStandard(int amount)
    {
        currentHealth = (int)Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        onHealthChanged.Invoke();
        if (currentHealth == 0)
            onDie.Invoke();
    }

    private void Update()
    {
        if (intVariable != null && intVariable.RuntimeValue != currentHealth)
            ModifyHealth(0);
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void UpdateIntVarWithCurrentHealth(IntVariable variable)
    {
        variable.RuntimeValue = currentHealth;
    }

    public void UpdateIntVarWithMaxHealth(IntVariable variable)
    {
        variable.RuntimeValue = maxHealth;
    }
}