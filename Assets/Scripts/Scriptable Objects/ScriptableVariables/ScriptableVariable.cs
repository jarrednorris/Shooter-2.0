using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableVariable<T> : ScriptableObject
{
    public T InitialValue;
    public T RuntimeValue;

    private void OnEnable()
    {
        RuntimeValue = InitialValue;
    }
}