using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyWave : ScriptableObject
{
    public float spawnDelay = 5.0f;
    public ObjectSpawn[] wavePrefabs;

    [Range(0, 1)]
    public float pickupSpawnChance;

    public List<Transform> SpawnWave(Vector3 position)
    {
        List<Transform> wave = new List<Transform>(wavePrefabs.Length);
        for(int i = 0; i < wavePrefabs.Length; i++)
        {
            GameObject obj = GameObject.Instantiate(wavePrefabs[i].prefab, wavePrefabs[i].position + position, Quaternion.identity);
            wave.Add(obj.transform);
        }
        return wave;
    }

    [System.Serializable]
    public struct ObjectSpawn
    {
        public GameObject prefab;
        public Vector3 position;
    }
}