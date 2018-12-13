using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private bool canFire;

    public PlayerAbilities abilities;
    public Weapon weapon;

    public int bulletDamage;
    public float bulletSpeed;

    public float shootDelay;

    public void Update()
    {
        if(Input.GetButton("Fire1") && canFire)
        {
            weapon.Fire(bulletDamage + (int)abilities.damageBuff.amount, bulletSpeed, true);
            StartCoroutine(WaitForFire(shootDelay - abilities.shootBuff.amount));
        }
    }

    IEnumerator WaitForFire(float timeToWait)
    {
        canFire = false;

        yield return new WaitForSeconds(timeToWait);

        canFire = true;
    }
}
