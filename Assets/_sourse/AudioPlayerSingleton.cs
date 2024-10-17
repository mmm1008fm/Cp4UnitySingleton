using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerSingleton : MonoBehaviour
{
    public static AudioPlayerSingleton Instance {  get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }
    public void PlaySound()
    {
        Debug.Log("Play sound!");
    }
}
