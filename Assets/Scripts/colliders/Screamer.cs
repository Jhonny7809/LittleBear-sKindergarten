using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public AudioSource audioSource;

    public CameraShake cameraShake;

    public GameObject Panel;

    public GameObject coll;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!activated)
            {
                Panel.SetActive(true);
                audioSource.enabled = true;
                StartCoroutine(cameraShake.Temblor());
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Panel.SetActive(false); 
            audioSource.enabled = false;
            Destroy(coll); coll = null;
        }

        
        
    }
}
