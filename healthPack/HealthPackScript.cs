using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPackScript : MonoBehaviour
{
   public float giveHealth = 10f;

   public void destroyThis()
   {
        Destroy(gameObject);
   }
}
