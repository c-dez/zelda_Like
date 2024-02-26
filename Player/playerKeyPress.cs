using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    private bool key_q;
    private bool key_e;
    private bool key_space;

    private bool key_mouseLeft;
    private bool key_mouseRight;


    void Start()
    {
    }

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
            Debug.Log("Q");
        }

        if (key_e)
        {
            Debug.Log("e");
        }
        
        if (key_space)
        {
            Debug.Log("space");
        }

        if (key_mouseLeft)
        {
            Debug.Log("left mouse");
        }
        
        if (key_mouseRight)
        {
            Debug.Log("right mouse");
        }
    }
    
    
}
