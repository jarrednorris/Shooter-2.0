using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour {

    public AudioMixer masterMixer;
    

    public void setSoundLevel(float soundLevel)
    {
        masterMixer.SetFloat("Volume", soundLevel);
    }
}
