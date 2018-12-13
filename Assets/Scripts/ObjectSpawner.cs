using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public void SpawnObject(GameObject prefab)
    {
        GameObject.Instantiate(prefab, transform.position, Quaternion.identity);
    }
}