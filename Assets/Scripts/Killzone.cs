using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    public Vector2 size;

    public void FixedUpdate()
    {
        Collider2D[] col = Physics2D.OverlapBoxAll(transform.position, size, 0);
        for (int i = 0; i < col.Length; i++)
            Destroy(col[i].gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(transform.position, (Vector3)size);
    }
}
