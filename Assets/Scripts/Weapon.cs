using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePoint;

    public LayerMask bulletsShouldDamage;
    public FirePattern pattern;

    public void Fire(int damage, float bulletSpeed, bool fireRight)
    {
        for(int i = 0; i < pattern.pattern.Length; i++)
        {
            FirePattern.SpawnPattern pat = pattern.pattern[i];

            Vector3 position = pat.position;
            position.x *= (fireRight) ? 1 : -1;

            GameObject bulletObj = GameObject.Instantiate(pat.bulletPrefab, firePoint.position + position, Quaternion.identity);

            Vector2 direction = pat.direction;
            direction.x *= (fireRight) ? 1 : -1;
            bulletObj.GetComponent<BulletScript>().Impulse(damage, bulletSpeed, direction, bulletsShouldDamage);
        }
    }
}