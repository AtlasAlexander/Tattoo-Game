using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomDoorManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject gameManagerObject;

    void Awake()
    {
        gameManagerObject = GameObject.Find("Game Manager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.playerLeavesHome = true;
        }
    }
}
