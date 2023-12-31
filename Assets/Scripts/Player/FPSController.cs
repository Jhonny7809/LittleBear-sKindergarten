using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FPSController : MonoBehaviour
{
    CharacterController characterController;

    [Header("Opciones de Personaje")]
    public float walkSpeed = 6.0f;
    public float runSpeed = 10.0f;
    public float jumSpeed = 8.0f;
    public float gravity = 20.0f;

    [Header("Opciones de Camara")]
    public Camera cam;
    public float mouseHorizontal = 3.0f;
    public float mouseVertical = 2.0f;
    public float minRotation = -65.0f;
    public float maxRotation = 60.0f;
    float h_mouse,v_mouse;

    private Vector3 move = Vector3.zero;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        v_mouse += mouseVertical * Input.GetAxis("Mouse Y");

        v_mouse = Mathf.Clamp(v_mouse,minRotation,maxRotation);
        cam.transform.localEulerAngles = new Vector3(-v_mouse,0,0);
        transform.Rotate(0, h_mouse, 0);

        if (characterController.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            if (Input.GetKey(KeyCode.LeftShift))
                move = transform.TransformDirection(move) * runSpeed;
            else
                move = transform.TransformDirection(move) * walkSpeed;

            if (Input.GetKey(KeyCode.Space))
                move.y = jumSpeed;
        }
        move.y -= gravity * Time.deltaTime; 

        characterController.Move(move * Time.deltaTime);
    }
}