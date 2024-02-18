using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private CharacterController controller;
    void Start()
    {
        
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
            controller.Move(direction * speed * Time.deltaTime);
            Debug.Log(direction);
        }
    }

}

