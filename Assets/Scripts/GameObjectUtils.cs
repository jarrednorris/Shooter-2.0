using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectUtils : MonoBehaviour
{
    public void DestroyObject(GameObject obj)
    {
        Destroy(obj);
    }

    public void PrintMessage(string msg)
    {
        Debug.Log(msg);
    }
}