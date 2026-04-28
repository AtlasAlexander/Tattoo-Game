using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
  
    public GameObject[] NPCs; 

    // Collates all objects with tag NPC into a list for later usage
    public void FindNPCs() 
    {
        NPCs = GameObject.FindGameObjectsWithTag("NPC");
    }

    // This function makes all NPC's that are not the one needed invisable.
    // This works fine for the purpose of this game but will need to be heavily built upon if you need more than 1 npc present per screen
    public void MakeVisable(string NPCName)
    {
        foreach (GameObject npc in NPCs)
        {
            if (npc.name == NPCName)
            {
                npc.SetActive(true);
            }
            else if (npc.name != NPCName)
            {
                npc.SetActive(false);
            }
        }
    }
}
