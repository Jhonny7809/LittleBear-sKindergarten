using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text numero;
    public Inventario inventario;

    void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        numero.text = inventario.Cantidad + " / 4";
    }
}
