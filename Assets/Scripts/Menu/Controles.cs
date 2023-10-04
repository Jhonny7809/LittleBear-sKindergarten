using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    public GameObject panel; // Asigna tu panel desde el Inspector

    public void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf); // Activa o desactiva el panel según su estado actual
    }
}
