using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private AudioSource msrc;

    private void start()
    {
        msrc = GetComponent<AudioSource>();
        msrc.volume = 0f;
    }

   //public IEnumerator Fade(bool fadeIn, AudioSource msrc)
    
}
