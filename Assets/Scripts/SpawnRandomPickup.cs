using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomPickup : MonoBehaviour
{
    [Range(0, 1)]
    public float randomChance;

    public GameObject[] prefabs;
    System.Random rnd = new System.Random();

    public void SpawnRandomPrefab()
    {
        if(rnd.NextDouble() < randomChance)
        {
            int index = rnd.Next(0, prefabs.Length);
            GameObject.Instantiate(prefabs[index], transform.position, Quaternion.identity);
        }
    }
}