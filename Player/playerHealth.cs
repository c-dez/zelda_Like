using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    [SerializeField] private float baseHealth = 100f;
    [SerializeField] private float healtMod = 1f;
    private float maxHealth;
    private float currentHealth;

    void Start()
    {
        
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
            

            Debug.Log(healthPackScript.giveHealth);
        }
    }
}

       