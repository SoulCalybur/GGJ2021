using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private bool isDigging = false;

    private Vector2 moveInput = new Vector2();
    private CharacterController controller;
    private Vector3 velocity;
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float rotationSpeed = 5f;
    private float gravity = -9.81f;

    private Transform cameraTransform;

    public void PollMovementInput(InputAction.CallbackContext context) {
        Debug.Log(context);
        moveInput = context.ReadValue<Vector2>();
    }

    public void PollDigButton(InputAction.CallbackContext context) {
        bool digging = context.action.triggered;
        if(digging == true) {
            isDigging = true;
        }
    }

    private void OnEnable() {
    }
    private void Start() {
        controller = gameObject.GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform;
    }
    // Update is called once per frame
    void Update() {
        if(isDigging == true) {
            digUpdate();
        } else {
            moveUpdate();
        }
    }

    private void moveUpdate() {
        velocity.y = 0;

        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        move.y = 0;
        controller.Move(move * Time.deltaTime * moveSpeed);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity);

        if (moveInput != Vector2.zero) {
            float targetAngle = Mathf.Atan2(moveInput.x, moveInput.y) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0f, targetAngle, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
        }
    }

    private void digUpdate() {
    }

}
