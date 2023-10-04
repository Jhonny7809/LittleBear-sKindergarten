using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : Interactable
{
    public GameObject pz;
    public Inventario inventario;

    public override void Interact()
    {
        base.Interact();
        inventario.Cantidad = inventario.Cantidad += 1;
        pz.SetActive(true);
        Destroy(gameObject);
    }
}
