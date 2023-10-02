using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevarRepisa2 : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool(("movimiento"), true);
        }
    }
}
