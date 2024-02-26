using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    
    public int enemyHealth;
    public int enemyAttack;

    // Start is called before the first frame update
    void Start()
    {
        //Enemy health and attack are a value between two random number ranges, also known as RNG
        enemyHealth = Random.Range(20, 30);
        enemyAttack = Random.Range(5, 10);

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
