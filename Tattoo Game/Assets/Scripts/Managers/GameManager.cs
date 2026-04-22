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
    private NPCManager npcManager;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        introCanvas = GameObject.Find("IntroCanvas");
        GameObject[] spawns = GameObject.FindGameObjectsWithTag("PlayerSpawn");
        textHandler = player.GetComponent<TextHandler>();
        npcManager = GetComponent<NPCManager>();
        foreach (GameObject obj in spawns)
        {
            spawnPoints.Add(obj.transform);
        }
    }

    void Start()
    {
        if (npcManager.NPCs != null)
        { npcManager.FindNPCs(); }
            
        if (!playerLeavesHome && textHandler.playIntro)
        {
            // Make sure movement is disabled at start so cutscene can playout first
            // Movement is reactivated in cutscene script upon completion
            if (playerController != null)
            {
                playerController.enabled = false;
            }
        }
    }

    private void Update()
    {
        if (textHandler != null)
        {
            if (textHandler.playIntro == false)
            {
                playerController.enabled = true;
            }
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

    // Scans for all data needed upon scene loading
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.FindWithTag("Player");
        introCanvas = GameObject.Find("IntroCanvas");
        playerController = player.GetComponent<PlayerController>();

        if (scene.name == "MainScene")
        {
            npcManager.FindNPCs();
            if (playerLeavesHome)
            {
                introCanvas.SetActive(false);

                if (npcManager.NPCs != null)
                {
                    npcManager.MakeVisable("NPC 2");
                }
                
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
                if (npcManager.NPCs != null)
                {
                    npcManager.MakeVisable("NPC 1");
                }
            }
        }
    }
}
