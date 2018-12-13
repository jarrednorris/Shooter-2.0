using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FirePattern : ScriptableObject
{
    public SpawnPattern[] pattern;

    [System.Serializable]
    public struct SpawnPattern
    {
        public GameObject bulletPrefab;
        public Vector2 direction;
        public Vector2 position;
    }
}
