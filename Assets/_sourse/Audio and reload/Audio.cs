using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    void Start()
    {
        AudioPlayerSingleton.Instance.PlaySound();
    }
}
