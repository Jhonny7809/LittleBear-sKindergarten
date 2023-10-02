using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevarobjetos : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool(("Subir"),true);
        }
    }
}
