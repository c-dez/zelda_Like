using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    [SerializeField] private float baseHealth = 100f;
    [SerializeField] private float healtMod = 1f;
    private float maxHealth;
    private float currentHealth = 80f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        maxHealth = baseHealth * healtMod;

        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "healthPack")
        {
            HealthPackScript healthPackScript = other.gameObject.GetComponent<HealthPackScript>();
            float giveHealth = healthPackScript.giveHealth;
            currentHealth +=giveHealth;

            Debug.Log(currentHealth);
        }
    }
}

       