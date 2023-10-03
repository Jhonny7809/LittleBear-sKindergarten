using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ColliderTrigger : MonoBehaviour
{
    public GameObject audioSorce;

    //public GameObject objeto;

    public GameObject Luz;

    public GameObject Coll;

    public CameraShake cameraShake;

    private bool activated = false;
    public float Rotacion = 1.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entro a Trigger");
        if(other.tag == "Player")
        {

            if (!activated)
            {
                Luz.SetActive(true);
                activated = true;

                audioSorce.SetActive(true);
                //objeto.SetActive(true);

                StartCoroutine(cameraShake.Temblor());
            }
        }


        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salio de Trigger");

        if (other.tag == "Player")
        {
            Luz.SetActive(false);
            audioSorce.SetActive(false) ;
            Coll.transform.position = Coll.transform.position + new Vector3(-50, -50, 0);
        }
        
    }
}
