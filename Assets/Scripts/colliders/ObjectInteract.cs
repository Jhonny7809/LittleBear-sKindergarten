using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    public GameObject pz;
    public Inventario inventario;
    // Start is called before the first frame update
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inventario.Cantidad = inventario.Cantidad += 1;
            pz.SetActive(true);
            Destroy(gameObject);
        }
    }
}
