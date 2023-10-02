using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    public Animator anim;
    public AudioSource coll;
    public AudioSource audiosource;

    public void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                coll.Stop();
                anim.SetBool(("Abrir"), true);
                audiosource.Play();
            }
        }
    }
}
