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
            coll.SetActive(false);
        }
    }
}
