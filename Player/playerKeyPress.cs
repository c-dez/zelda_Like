using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    private bool button_q;
    private bool button_e;
    private bool button_space;

    private bool button_mouseLeft;
    private bool button_mouseRight;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        button_q = Input.GetKey(KeyCode.Q);
        button_e = Input.GetKey(KeyCode.E);
        button_space = Input.GetKey(KeyCode.Space);

        button_mouseLeft = Input.GetMouseButton(0);
        button_mouseRight = Input.GetMouseButton(1);


        if (button_q)
        {
            Debug.Log("Q");
        }

        if (button_e)
        {
            Debug.Log("e");
        }
        
        if (button_space)
        {
            Debug.Log("space");
        }

        if (button_mouseLeft)
        {
            Debug.Log("left mouse");
        }
        
        if (button_mouseRight)
        {
            Debug.Log("right mouse");
        }
    }
    
    
}
