using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public Animator anim;

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
}
