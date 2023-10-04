using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteraction : MonoBehaviour
{
    public new Transform camera;
    public float rayDistance;

    private void Start()
    {
        camera = transform.Find("Camera");
    }
    private void Update()
    {
        Debug.DrawRay(camera.position,camera.forward * rayDistance, Color.green);
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable")))
            {
                hit.transform.GetComponent<Interactable>().Interact();
            }
        }
    }
}
