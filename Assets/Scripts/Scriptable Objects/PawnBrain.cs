using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PawnBrain : ScriptableObject
{
    public float timerStep = 0.1f;

    public virtual void OnAwake(Transform transform) { }
    public abstract void ProcessMovement(Movement movement, float time, float startHeight);
}