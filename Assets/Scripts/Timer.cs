using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer;
    public GameEvent onComplete;

    public void WaitForSeconds(float timeToWait)
    {
        timer = timeToWait;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                onComplete.Raise();
            }
        }
    }
}