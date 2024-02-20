using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    [SerializeField] private float baseHealth = 100f;
    [SerializeField] private float healtMod = 1f;
    private float maxHealth;
    public float currentHealth = 80f;

    void Start()
    {
        maxHealth = baseHealth * healtMod;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "healthPack")
        {
            HealthPackScript healthPackScript = other.gameObject.GetComponent<HealthPackScript>();
            float giveHealth = healthPackScript.giveHealth;
            currentHealth +=giveHealth;

            if (currentHealth >= maxHealth)
            {
                currentHealth = maxHealth;
            } 
              
            healthPackScript.destroyThis();         
            Debug.Log(currentHealth);
        }

        if (other.gameObject.tag == "enemy")
        {
            EnemyScript enemyScript = other.gameObject.GetComponent<EnemyScript>();
            float enemyDamage = enemyScript.damage;
            currentHealth -= enemyDamage;
            Debug.Log(currentHealth);
        }
    }
}

       