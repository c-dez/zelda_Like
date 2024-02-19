using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    private float runSpeed ;
    private CharacterController controller;
    private Renderer visual;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        visual = gameObject.transform.GetChild(0).GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        if(direction.magnitude >=0.1f)
        {
            direction = Vector3.ClampMagnitude(direction , 1);
            controller.Move(direction * speed * runSpeed * Time.deltaTime);
            //Debug.Log(direction);
        }

        bool space = Input.GetKey(KeyCode.Space);

        if (space)
        {
            runSpeed = 2;
        }
        else
        {
            runSpeed = 1;
        }

        bool buttonQ = Input.GetKey(KeyCode.Q);
        if (buttonQ)
        {
            visual.material.color = Color.red;
        }
        else
        {
            visual.material.color = Color.gray;
        }
        
    }

}

