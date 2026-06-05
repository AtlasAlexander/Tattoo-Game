using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TattooBattle : MonoBehaviour
{
    [SerializeField] int tattooHealth;
    [SerializeField] int tattooMaxHealth = 100;
    [SerializeField] int levelInt;
    [SerializeField] int descisionTally;
    [SerializeField] string battleText;
    // Start is called before the first frame update
    void Start()
    {
        tattooHealth = tattooMaxHealth;
        levelInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(tattooHealth > tattooMaxHealth) { tattooHealth = tattooMaxHealth; }
    }
    public void Scratch()
    {
        switch (levelInt)
        {
            case 0:
                tattooHealth = tattooHealth - 35;
                descisionTally++;
                battleText = "Bingus Scratch 1";
                break;
            case 1:
                tattooHealth = tattooHealth - 20;
                descisionTally++;
                battleText = "Bingus Scratch 2";
                break;
            case 2:
                tattooHealth = tattooHealth - 20;
                descisionTally++;
                battleText = "Bingus Scratch 3";
                break;
            case 3:
                tattooHealth = tattooHealth - 25;
                descisionTally++;
                battleText = "Bingus Scratch 4";
                break;
            case 4:
                tattooHealth = tattooHealth - 35;
                descisionTally++;
                battleText = "Bingus Scratch 5";
                break;
            default:
                break;

        }
    }
    public void Ignore()
    {
        switch (levelInt)
        {
            case 0:
                tattooHealth = tattooHealth - 10;
                descisionTally++;
                battleText = "Bingus Ignore 1";
                break;
            case 1:
                tattooHealth = tattooHealth - 10;
                descisionTally++;
                battleText = "Bingus Ignore 2";
                break;
            case 2:
                tattooHealth = tattooHealth - 10;
                descisionTally++;
                battleText = "Bingus Ignore 3";
                break;
            case 3:
                tattooHealth = tattooHealth - 15;
                descisionTally++;
                battleText = "Bingus Ignore 4";
                break;
            case 4:
                tattooHealth = tattooHealth - 10;
                descisionTally++;
                battleText = "Bingus Ignore 5";
                break;
            default:
                break;

        }
    }
    public void Elevate()
    {
        switch (levelInt)
        {
            case 0:
                tattooHealth = tattooHealth + 10;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            case 1:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            case 2:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            case 3:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            case 4:
                tattooHealth = tattooHealth + 15;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            default:
                break;

        }
    }
    public void SoftScratcher()
    {
        switch (levelInt)
        {
            case 0:
                tattooHealth = tattooHealth + 10;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            case 1:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            case 2:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            case 3:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            case 4:
                tattooHealth = tattooHealth + 15;
                descisionTally++;
                battleText = "Bingus Elevate 5";
                break;
            default:
                break;

        }
    }
    public void Ibuprofen()
    {
        switch (levelInt)
        {
            case 0:
                tattooHealth = tattooHealth + 10;
                descisionTally++;
                battleText = "Bingus Ibuprofen 1";
                break;
            case 1:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Ibuprofen 2";
                break;
            case 2:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Ibuprofen 3";
                break;
            case 3:
                tattooHealth = tattooHealth + 15;
                descisionTally++;
                battleText = "Bingus Ibuprofen 4";
                break;
            case 4:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Ibuprofen 5";
                break;
            default:
                break;

        }
    }
    public void Clean()
    {
        switch (levelInt)
        {
            case 0:
                tattooHealth = tattooHealth + 0;
                descisionTally++;
                battleText = "Bingus Clean 1";
                break;
            case 1:
                tattooHealth = tattooHealth + 25;
                descisionTally++;
                battleText = "Bingus Clean 2";
                break;
            case 2:
                tattooHealth = tattooHealth + 15;
                descisionTally++;
                battleText = "Bingus Clean 3";
                break;
            case 3:
                tattooHealth = tattooHealth + 15;
                descisionTally++;
                battleText = "Bingus Clean 4";
                break;
            case 4:
                tattooHealth = tattooHealth + 10;
                descisionTally++;
                battleText = "Bingus Clean 5";
                break;
            default:
                break;

        }
    }
    public void Pull()
    {
        switch (levelInt)
        {
            case 0:
                tattooHealth = tattooHealth - 5;
                descisionTally++;
                battleText = "Bingus Pull 1";
                break;
            case 1:
                tattooHealth = tattooHealth - 25;
                descisionTally++;
                battleText = "Bingus Pull 2";
                break;
            case 2:
                tattooHealth = tattooHealth - 15;
                descisionTally++;
                battleText = "Bingus Pull 3";
                break;
            case 3:
                tattooHealth = tattooHealth - 10;
                descisionTally++;
                battleText = "Bingus Pull 4";
                break;
            case 4:
                tattooHealth = tattooHealth - 15;
                descisionTally++;
                battleText = "Bingus Pull 5";
                break;
            default:
                break;

        }
    }
    public void Cream()
    {
        switch (levelInt)
        {
            case 0:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Cream 1";
                break;
            case 1:
                tattooHealth = tattooHealth + 5;
                descisionTally++;
                battleText = "Bingus Cream 2";
                break;
            case 2:
                tattooHealth = tattooHealth + 15;
                descisionTally++;
                battleText = "Bingus Cream 3";
                break;
            case 3:
                tattooHealth = tattooHealth - 10;
                descisionTally++;
                battleText = "Bingus Cream 4";
                break;
            case 4:
                tattooHealth = tattooHealth + 15;
                descisionTally++;
                battleText = "Bingus Cream 5";
                break;
            default:
                break;

        }
    }
    public void ContactAnna()
    {
        switch (levelInt)
        {
            case 0:
                battleText = "Anna Says 1";
                break;
            case 1:
                battleText = "Anna Says 2";
                break;
            case 2:
                battleText = "Anna Says 3";
                break;
            case 3:
                battleText = "Anna Says 4";
                break;
            case 4:
                battleText = "Anna Says 5";
                break;
            default:
                break;

        }
    }

    public IEnumerator LevelUpManager()
    {
        yield return new WaitForSeconds(0.5f);
        descisionTally = 0;
    }

}

