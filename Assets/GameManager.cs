using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void ClearLevel()
    {
        DestroyList(GameObject.FindGameObjectsWithTag("Bullet"));
        DestroyList(GameObject.FindGameObjectsWithTag("Enemy"));
        DestroyList(GameObject.FindGameObjectsWithTag("Pickup"));
    }

    public void DestroyList(GameObject[] gameObjects)
    {
        for (int i = 0; i < gameObjects.Length; i++)
            GameObject.Destroy(gameObjects[i]);
    }
}