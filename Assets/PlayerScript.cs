using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //Establish vairables, put types of Public ints before void start

    public int playerHealth = 100;
    public int playerLevel = 1;
    public int playerAttack = 10;
    public int playerXp = 0;
    public int xpCap = 20;
    public int playerlevel1 = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        //Player health and attack power are set to a random number between two values
        playerHealth = Random.Range(50, 110);
        playerAttack = Random.Range(8, 16);

    }

    // Update is called once per frame
    void Update()
    {
        //If player reaches cp cap, run level up function. Then Reset Xp.
        if (playerXp >= xpCap)
        {
            PlayerLevelUp();
            playerXp = 0;
        }

    }

    void PlayerLevelUp()
    {
        //Player level up goes by 1
        playerLevel++;
        Debug.Log("LEVEL UP! You are now level" + playerlevel1);
        //Player attack power goes up by 10
        playerAttack += 10;
        //Xp cap goes up by 10.
        xpCap += 10;

    }
}