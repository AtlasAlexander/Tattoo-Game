using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenManager : MonoBehaviour
{
    public int playerScore;
    public GameObject goodEndingUI;
    public GameObject badEndingUI;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(playerScore>0)
            { goodEndingUI.SetActive(true); }
            else { badEndingUI.SetActive(true); }
        }
    }
}
