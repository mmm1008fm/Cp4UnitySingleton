using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputListener : MonoBehaviour
{
    [SerializeField] private KeyCode reloadKey;
    void Update()
    {
        ListenExitApp();
    }
    private void ListenExitApp()
    {
        if (Input.GetKeyDown(reloadKey))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
