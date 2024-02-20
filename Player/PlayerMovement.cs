using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    private float runSpeed ;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        if(direction.magnitude >=0.1f)
        {
            direction = Vector3.ClampMagnitude(direction, 1);
            controller.Move(direction * speed * runSpeed * Time.deltaTime);
            //Debug.Log(direction);
        }
        //character rotation
        if (direction != Vector3.zero)
        {
            transform.forward = direction;
        }
    }
}

