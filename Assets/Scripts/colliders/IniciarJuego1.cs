using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarJuego1 : MonoBehaviour
{
    public Inventario inventario;
    public GameObject canvasPlayerGUI;
    public GameObject hud;
    public FPSController fpsController;
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
        fpsController = GameObject.FindGameObjectWithTag("Player").GetComponent <FPSController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && inventario.Cantidad == 4)
        {
            hud.SetActive(false);
            canvasPlayerGUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            fpsController.enabled = false;
            Destroy(gameObject);
        }
    }
}
