using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;

public class BattleScript : MonoBehaviour
{
    public EnemyScript enemyScript;
    public PlayerScript playerScript;

    
    // Start is called before the first frame update
    void Start()
    {
        //Print out player stats
        Debug.Log("Welcome Challenger! Your Health:" + playerScript.playerHealth + "Your Attack Damage:" + playerScript.playerAttack + "Your Level:" + playerScript.playerLevel);
    }

    // Update is called once per frame
    void Update()
    {
        //When I press R for ready. Print Message. An enemy has appeared
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("An enemy has approched! Their health is:" + enemyScript.enemyHealth);
            Debug.Log("Well dont just stand there!!! Hit the damn thing using W!!");
        }
        //When the player presses W the player attack using the playerAttack value and then reduce the enemys health
        if (Input.GetKeyDown (KeyCode.W))
        {
            enemyScript.enemyHealth = enemyScript.enemyHealth - playerScript.playerAttack;
            Debug.Log("Great Hit! WOW The enemies health is now at" + enemyScript.enemyHealth);
        }
        //if the enemy reaches 0 health print a victory message and if not then print a motivational message
        if (enemyScript.enemyHealth <= 0)
        {
            VictoryState();
            AddXp (10);
            Destroy(gameObject);


        }
    }
    void VictoryState()
    {
        Debug.Log("Thank you for saving us!");

    }

    void AddXp(int experience)
    {
        //The value of experience is added to the Player xp Total.
        playerScript.playerXp += experience;
        Debug.Log("Thats a lot of xp Challenger, Have a look " + playerScript.playerXp);
    }

}
