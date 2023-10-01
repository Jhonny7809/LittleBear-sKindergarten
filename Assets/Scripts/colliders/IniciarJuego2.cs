using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarJuego2 : MonoBehaviour
{
    public GameObject canvasPlayerGUI;
    public FPSController fpsController;
    void Start()
    {
        fpsController = GameObject.FindGameObjectWithTag("Player").GetComponent <FPSController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                canvasPlayerGUI.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                fpsController.enabled = false;
            Destroy(gameObject);
        }
    }
}
