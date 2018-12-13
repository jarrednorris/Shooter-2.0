using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Int Variable")]
public class IntVariable : ScriptableVariable<int>
{
    public void Increment() { RuntimeValue++; }
    public void Decrement() { RuntimeValue--; }

    public void Add(int amount) { RuntimeValue += amount; }
    public void Subtract(int amount) { RuntimeValue -= amount; }

    public void Set(int amount) { RuntimeValue = amount; }
}