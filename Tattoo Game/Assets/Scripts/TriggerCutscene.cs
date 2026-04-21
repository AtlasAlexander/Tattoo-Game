using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCutscene : MonoBehaviour
{
    public CinemachineVirtualCamera battleCam;
    public GameObject battleUI;

    [SerializeField] private float tranistionTimer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
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


