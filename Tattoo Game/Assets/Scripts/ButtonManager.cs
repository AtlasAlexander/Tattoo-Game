using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ButtonManager : MonoBehaviour
{

    public CinemachineVirtualCamera battleCam;
    public GameObject battleUI;
    public EndScreenManager endScreenManager;


    // Transitions back to the main view
    IEnumerator BattleUIDelay()
    {
        battleUI.SetActive(false);
        yield return new WaitForSeconds(.5f);
        battleCam.Priority = 0;
    }

    // Updates decision tree with option chosen
    public void BadOption()
    {
        endScreenManager.playerScore--;
        StartCoroutine(BattleUIDelay());
    }

    public void GoodOption()
    {
        endScreenManager.playerScore++;
        StartCoroutine(BattleUIDelay());
    }
}
