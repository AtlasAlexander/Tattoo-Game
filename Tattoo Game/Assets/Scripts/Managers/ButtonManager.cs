using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ButtonManager : MonoBehaviour
{

    public CinemachineVirtualCamera battleCam;
    public GameObject battleUI;
    public EndScreenManager endScreenManager;
    GameManager gameManager;

    [SerializeField] public int endingInt;

    private void Start()
    {
        GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }


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
        if (gameManager.BattleInt == 2)
        {
            gameManager.playerScore = -2;
        }
        else if (gameManager.BattleInt == 4)
        {
            gameManager.playerScore = -4;
        }
        StartCoroutine(BattleUIDelay());
    }

    public void GoodOption()
    {
        if (gameManager.playerScore >= 0)
        {
            gameManager.playerScore = 1;
        }
        StartCoroutine(BattleUIDelay());
    }
}
