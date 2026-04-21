using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneInt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneInt);
        }
    }
    // Switch using scene name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene("MainScene");
    }
}