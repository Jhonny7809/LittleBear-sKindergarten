using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public AudioSource sonido;
    public Animator anim;
    public GameObject coll;

    public void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                anim.SetBool(("Abrir"), true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.tag == "Player" && !sonido.isPlaying)
            {
                sonido.Play();
                coll.SetActive(false);
            }
        }
    }
}
