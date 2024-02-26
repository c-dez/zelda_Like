using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    private bool button_q;
    private bool button_e;
    private bool button_space;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        button_q = Input.GetKey(KeyCode.Q);
        button_e = Input.GetKey(KeyCode.E);
        button_space = Input.GetKey(KeyCode.Space);

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
        
    }
    
    
}
