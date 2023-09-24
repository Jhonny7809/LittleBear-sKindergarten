using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarJuego1 : MonoBehaviour
{
    public Inventario inventario;
    public GameObject canvasPlayerGUI;
    public FPSController fpsController;
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
        fpsController = GameObject.FindGameObjectWithTag("Player").GetComponent <FPSController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (inventario.Cantidad == 0)
            {
                canvasPlayerGUI.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                fpsController.enabled = false;
            }
            Destroy(gameObject);
        }
    }
}
