using UnityEngine;
using TMPro;

public class TextHandler : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] messages;

    public GameObject canvasToHide;

    private int currentIndex = 0;
    public bool playIntro = true;

    void Start()
    {
        if (messages.Length > 0)
        {
            textDisplay.text = messages[currentIndex];
        }
    }

    void Update()
    {
        if (playIntro)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                NextText();
            }
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

        playIntro = false;

        // Disable this script
        this.enabled = false;
    }
}