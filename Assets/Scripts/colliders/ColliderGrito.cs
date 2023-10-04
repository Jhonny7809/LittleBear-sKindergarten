using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderGrito : MonoBehaviour
{
    public AudioSource audio1;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            audio1.Play();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            audio1.Stop();
        }
        
    }
}
