using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKeyPress : MonoBehaviour
{
    /*
    este script se hace cargo de registray inputs/botones de jugador
    asignar esos botones a acciones
    */
    private bool key_q;
    private bool key_e;
    private bool key_space;

    private bool key_mouseLeft;
    private bool key_mouseRight;

    //raycast
    [SerializeField] private float rayDistance;


   

    // Update is called once per frame
    void Update()
    {
        key_q = Input.GetKey(KeyCode.Q);
        key_e = Input.GetKey(KeyCode.E);
        key_space = Input.GetKey(KeyCode.Space);

        key_mouseLeft = Input.GetMouseButton(0);
        key_mouseRight = Input.GetMouseButton(1);


        if (key_q)
        {
            // Debug.Log("Q");
        }

        if (key_e)
        {
            // Debug.Log("e");
        }
        
        if (key_space)
        {
            // Debug.Log("space");
        }

        if (key_mouseLeft)
        {
            // Debug.Log("left mouse");
        }
        
        if (key_mouseRight)
        {
            // Debug.Log("right mouse");
        }
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        // Ray rayDirection = new Ray(transform.position, Vector3.forward);

         bool key_mouseLeft = Input.GetMouseButton(0);


        Debug.DrawRay
            (transform.position, 
            transform.TransformDirection(Vector3.forward) * rayDistance, Color.red);

        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),
             out hit, rayDistance))
        {
            if (hit.collider.tag == "NPC" && key_mouseLeft)
            {
                Debug.Log("NPC");
            }
        }
        
        
    }
    
    
}
