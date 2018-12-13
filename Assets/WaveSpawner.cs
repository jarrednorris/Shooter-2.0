using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public EnemyWave[] waves;    

    private float timer;
    private int counter;

    private List<Wave> m_enemyWaveList = new List<Wave>();

    private System.Random rnd = new System.Random();
    public GameObject[] powerupPrefabs;

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            if (counter == waves.Length)
                counter = 0;

            EnemyWave wave = waves[counter];
            timer = wave.spawnDelay;
            counter++;

            m_enemyWaveList.Add(new Wave(wave.SpawnWave(transform.position)));
            m_enemyWaveList[m_enemyWaveList.Count - 1].pickupSpawnChance = wave.pickupSpawnChance;
        }

        for(int i = 0; i < m_enemyWaveList.Count; i++)
        {
            Wave wave = m_enemyWaveList[i];
            for (int j = 0; j < wave.Count(); j++)
            {
                if (!wave.enemies[j])
                    wave.enemies.RemoveAt(j);
                else
                    wave.lastPos = wave.enemies[j].position;
            }
            if (wave.Count() == 0)
            {
                if((float)rnd.NextDouble() < wave.pickupSpawnChance)
                    SpawnRandomPowerup(wave.lastPos);
                m_enemyWaveList.Remove(wave);
            }
        }        
    }

    public void SpawnRandomPowerup(Vector3 position)
    {
        int index = rnd.Next(0, powerupPrefabs.Length);
        GameObject.Instantiate(powerupPrefabs[index], position, Quaternion.identity);
    }

    public void ClearWaves()
    {
        m_enemyWaveList.Clear();
    }

    class Wave
    {
        public List<Transform> enemies;
        public Vector3 lastPos;

        public float pickupSpawnChance;

        public Wave(List<Transform> wave)
        {
            enemies = wave;
            lastPos = Vector3.zero;
        }

        public int Count() { return enemies.Count; }
    }
}