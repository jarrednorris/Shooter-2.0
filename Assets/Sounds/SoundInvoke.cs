using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundInvoke : MonoBehaviour
{
    public AudioClip clip; //make sure you assign an actual clip here in the inspector

    public void playclip()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
