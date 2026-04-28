using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedManager : MonoBehaviour
{
    [SerializeField] private GameObject sleepText;
    private bool bedtime;
    private bool hasSlept;

    // Start is called before the first frame update
    void Start()
    {
        sleepText.SetActive(false);
        hasSlept = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sleepText.SetActive(true);
            if (!hasSlept)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    bedtime = true;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sleepText.SetActive(false);
        }
    }

    void Update()
    {
        if (bedtime) 
        {

        }
    }

}
