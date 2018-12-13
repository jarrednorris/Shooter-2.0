using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float time, startHeight;
    public float minY, maxY;

    public bool clampXAxis;
    public float minX, maxX;

    public PawnBrain brain;

    private void Awake()
    {
        startHeight = transform.position.y;
    }

    private void Update()
    {
        time += Time.deltaTime * brain.timerStep;
        if (time >= 1.0f)
            time -= 1.0f;
        brain.ProcessMovement(this, time, startHeight);
    }

    public void Move(Vector2 movement)
    {
        movement.y = Mathf.Clamp(movement.y + transform.position.y, minY, maxY) - transform.position.y;

        if (clampXAxis)
            movement.x = Mathf.Clamp(movement.x + transform.position.x, minX, maxX) - transform.position.x;

        transform.Translate(movement);
    }
}