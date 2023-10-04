using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerSonido : MonoBehaviour
{
    public GameObject coll;
    public AudioSource audiosource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !audiosource.isPlaying)
        {
            audiosource.Play();
            
            
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(coll);
    }
}
