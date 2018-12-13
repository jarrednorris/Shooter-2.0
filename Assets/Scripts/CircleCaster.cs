using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CircleCaster : MonoBehaviour
{
    public float checkRadius = 1.0f;
    public UnityEvent onTouchObject;
    public LayerMask mask;

    private void FixedUpdate()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, checkRadius, mask);
        if(collider)        
            onTouchObject.Invoke();        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, checkRadius);
    }
}