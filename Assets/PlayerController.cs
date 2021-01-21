using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CharacterController p_controller;
    public float movementSpeed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (p_controller == null)
        {
            p_controller = gameObject.GetComponent<CharacterController>();
        }   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0f)
        {
            float movement = Input.GetAxisRaw("Horizontal");
            movement *= movementSpeed;
            movement *= Time.deltaTime;
            p_controller.Move(new Vector2(movement, 0));
        }

        // temporary vertical movement for testing
        if (Input.GetAxis("Vertical") != 0f)
        {
            float movement = Input.GetAxisRaw("Vertical");
            movement *= movementSpeed;
            movement *= Time.deltaTime;
            p_controller.Move(new Vector2(0, movement));
        }
    }
}
