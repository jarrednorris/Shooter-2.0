using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onTrigger;
    public LayerMask mask;

    public Vector2 size;

    public void FixedUpdate()
    {
        Collider2D col = Physics2D.OverlapBox(transform.position, size, 0, mask);
        if (col)
            onTrigger.Invoke();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(transform.position, (Vector3)size);
    }
}
