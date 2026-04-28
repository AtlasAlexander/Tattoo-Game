using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCutscene : MonoBehaviour
{
    public CinemachineVirtualCamera battleCam;
    public GameObject battleUI;
    [SerializeField] private int BattleInt;
    [SerializeField] private float tranistionTimer;

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
            gameManager.BattleInt = BattleInt;
            battleCam.Priority = 11;
            StartCoroutine(BattleUIDelay());
            GetComponent<Collider>().enabled = false;
        }

        IEnumerator BattleUIDelay()
        {
            yield return new WaitForSeconds(tranistionTimer);
            battleUI.SetActive(true);
        }
    }
}


