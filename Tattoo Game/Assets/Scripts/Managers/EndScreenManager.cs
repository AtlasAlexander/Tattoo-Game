using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenManager : MonoBehaviour
{
    public GameObject goodEndingUI;
    public GameObject badEndingUI1;
    public GameObject badEndingUI2;
   GameManager gameManager;

    private void Start()
    {
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameManager.playerScore == 1)
            { goodEndingUI.SetActive(true); }

            else if (gameManager.playerScore == -2)
            {
                badEndingUI1.SetActive(true);
            }
            else if (gameManager.playerScore == -4)
            { 
                badEndingUI2.SetActive(true);
            }
        }
    }
}
