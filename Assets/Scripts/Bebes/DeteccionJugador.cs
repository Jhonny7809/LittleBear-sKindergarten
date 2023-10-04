using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionJugador : MonoBehaviour
{
    public float Rango;

    public AudioSource audioSource;

    public LayerMask capaJugador;

    bool estaralerta;

    public GameObject Bebe;

    public Transform Jugador;

    public float velocidad;

    public GameObject canvas;

    private bool activated = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        estaralerta = Physics.CheckSphere(transform.position, Rango, capaJugador);

        if (estaralerta == true)
        {
            Vector3 posicionJugador = new Vector3(Jugador.position.x, transform.position.y, Jugador.position.z);
            transform.LookAt(posicionJugador);
            transform.position = Vector3.MoveTowards(transform.position, posicionJugador, velocidad * Time.deltaTime);

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Rango);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!activated)
            {
                canvas.SetActive(true);
                audioSource.Play();
                Debug.Log("Activado");
            }
            Destroy(Bebe);
        }
    }
}
