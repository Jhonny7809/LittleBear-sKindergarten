using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ColliderTrigger : MonoBehaviour
{
    public  AudioSource audioSorce;

    //public GameObject objeto;

    public GameObject Luz;

    public GameObject Coll;

    public CameraShake cameraShake;

    private bool activated = false;
    public float Rotacion = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            if (!activated)
            {
                Luz.SetActive(true);
                activated = true;

                audioSorce.Play();
                //objeto.SetActive(true);

                StartCoroutine(cameraShake.Temblor());
            }
        }


        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Luz.SetActive(false);
            Coll.transform.position = Coll.transform.position + new Vector3(-50, -50, 0);
        }
        
    }
}
