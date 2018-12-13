using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    public Weapon weapon;

    public int bulletDamage;
    public float bulletSpeed;

    public float shootDelay;

    private void Awake()
    {
        StartCoroutine(WaitForFire());
    }

    IEnumerator WaitForFire()
    {
        weapon.Fire(bulletDamage, bulletSpeed, false);
        yield return new WaitForSeconds(shootDelay);
        StartCoroutine(WaitForFire());
    }
}
