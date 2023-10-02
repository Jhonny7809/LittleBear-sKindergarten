using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public AudioSource audioSource;

    public CameraShake cameraShake;

    public GameObject canvas;

    public GameObject coll;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!activated)
            {
                canvas.SetActive(true);
                audioSource.enabled = true;
                StartCoroutine(cameraShake.Temblor());
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(false); 
            audioSource.enabled = false;
            Destroy(coll); coll = null;
        }

        
        
    }
}
