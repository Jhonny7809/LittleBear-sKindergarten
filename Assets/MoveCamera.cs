using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector2 Sens;
    private new Transform camera;
    void Start()
    {
        camera = transform.Find("Camera");
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");

        if (hor != 0)
        {
            transform.Rotate(Vector3.up * hor * Sens.x);
        }

        if (ver != 0)
        {
            //camera.Rotate(Vector3.left ver * Sens.y);
            float angle = (camera.localEulerAngles.x - ver * Sens.y + 360) % 360;
            if (angle > 180)
            {
                angle -= 360;
            }
            angle = Mathf.Clamp(angle, -75, 75);
            camera.localEulerAngles = Vector3.right * angle;
        }
    }
}
