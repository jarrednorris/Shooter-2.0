using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Brains/AIBrain")]
public class AIBrain : PawnBrain
{
    [SerializeField] public float animationScale = 1.0f;

    public float moveSpeed = 5;
    public AnimationCurve curve;

    public override void ProcessMovement(Movement movement, float time, float startHeight)
    {
        Transform transform = movement.transform;

        transform.position = new Vector3(transform.position.x - Time.deltaTime * moveSpeed, curve.Evaluate(time) * animationScale + startHeight, 0);
    }
}