using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public AudioSource sonido1;
    public AudioSource sonido2;
    public Animator anim;

    public void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                anim.SetBool(("Abrir"), true);
                sonido1.Pause();
                sonido2.Play();
            }
        }
    }
}
