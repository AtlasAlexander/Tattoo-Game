using UnityEngine;
using TMPro;

public class TextHandler : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] messages;

    public GameObject canvasToHide;

    private int currentIndex = 0;
    private MonoBehaviour playerController;

    void Start()
    {
        // Get the movement script on the same GameObject
        playerController = GetComponent<PlayerController>();

        // Make sure movement is disabled at start
        if (playerController != null)
        {
            playerController.enabled = false;
        }

        if (messages.Length > 0)
        {
            textDisplay.text = messages[currentIndex];
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextText();
        }
    }

    void NextText()
    {
        if (messages.Length == 0) return;

        currentIndex++;

        if (currentIndex >= messages.Length)
        {
            EndDialogue();
            return;
        }

        textDisplay.text = messages[currentIndex];
    }

    void EndDialogue()
    {
        // Hide UI
        if (canvasToHide != null)
        {
            canvasToHide.SetActive(false);
        }

        // Enable player movement
        if (playerController != null)
        {
            playerController.enabled = true;
        }

        // Disable this script
        this.enabled = false;
    }
}