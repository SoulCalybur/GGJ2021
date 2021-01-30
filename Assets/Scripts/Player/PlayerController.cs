using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private InputActionReference movementInput;

    private CharacterController controller;
    private Vector3 velocity;
    [SerializeField]
    private float moveSpeed = 5f;
    private float gravity = -9.81f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        velocity.y = 0;

        Vector2 moveInput = movementInput.action.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        controller.Move(move * Time.deltaTime * moveSpeed);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
