using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Switch using scene name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene("MainScene");
    }
}