using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private Vector2 direction;

    private float checkRadius = 0.25f;

    [SerializeField] private LayerMask bulletMask;

    public void Impulse(int damage, float bulletSpeed, Vector2 direction, LayerMask bulletMask)
    {
        this.damage = damage;
        this.bulletSpeed = bulletSpeed;
        this.direction = direction.normalized;
        this.bulletMask = bulletMask;
    }

    private void Update()
    {
        transform.Translate(direction * bulletSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, checkRadius, bulletMask);
        for (int i = 0; i < colliders.Length; i++)
        {
            Collider2D col = colliders[i];
            var health = col.GetComponent<HealthComponent>();
            if (health)
            {
                health.ModifyHealth(-damage);
                GameObject.Destroy(gameObject);
            }
        }
            //Debug.Log(col[i].gameObject.name);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, checkRadius);
    }
}