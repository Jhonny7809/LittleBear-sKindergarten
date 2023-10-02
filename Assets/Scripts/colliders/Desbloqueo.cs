using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desbloqueo : MonoBehaviour
{
    public Ahorcado ahorcado;
    public Win win;
    public GameObject colliderFinal;

    private void Update()
    {
        Activar();
    }

    private void Activar()
    {
        if (win.completado && ahorcado.completado)
        {
            colliderFinal.SetActive(true);
        }
    }
}
