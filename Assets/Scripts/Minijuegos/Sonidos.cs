using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource audiosource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !audiosource.isPlaying)
        {
            audiosource.Play();
        }
    }
}
