using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject introCanvas;
    public bool playerLeavesHome = false;
    public List<Transform> spawnPoints;
    private MonoBehaviour playerController;
    private TextHandler textHandler;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        introCanvas = GameObject.Find("IntroCanvas");
        GameObject[] spawns = GameObject.FindGameObjectsWithTag("PlayerSpawn");
        textHandler = player.GetComponent<TextHandler>();
        foreach (GameObject obj in spawns)
        {
            spawnPoints.Add(obj.transform);
        }
    }

    void Start()
    {
        if (!playerLeavesHome && textHandler.playIntro)
        {
            // Make sure movement is disabled at start
            if (playerController != null)
            {
                playerController.enabled = false;
            }
        }
    }

    private void Update()
    {
        if (textHandler.playIntro == false) 
        {
            playerController.enabled = true;
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    public void SetPlayerPosition(string spawnName)
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            foreach (Transform spawn in spawnPoints)
            {
                if (spawn.name == spawnName)
                {
                    player.transform.position = spawn.position;
                    return;
                }
            }

            Debug.LogError("Spawn not found: " + spawnName);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.FindWithTag("Player");
        introCanvas = GameObject.Find("IntroCanvas");
        playerController = player.GetComponent<PlayerController>();

        if (playerLeavesHome)
        {
            introCanvas.SetActive(false);
            if (playerController != null)
            {
                playerController.enabled = true;
            }
            else
            {
                Debug.LogError("Player not found!");
            }
            SetPlayerPosition("Spawn Position (2)");
        }

        else if (playerLeavesHome == false)
        {
            SetPlayerPosition("Spawn Position (1)");
        }
    }

    public void ChangeBool()
    {
        playerLeavesHome = true;
    }
}
