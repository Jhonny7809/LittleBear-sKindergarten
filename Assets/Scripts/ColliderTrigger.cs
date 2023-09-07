using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ColliderTrigger : MonoBehaviour
{
    public AudioSource audioSorce;

    public GameObject objeto;

    public Light Luz;

    public GameObject Coll;

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
            Luz.transform.rotation = Quaternion.Euler(100f,0f,0f);

            if (!activated)
            {
                activated = true;

                audioSorce.enabled = true;
                objeto.SetActive(true);
            }
        }


        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salio de Trigger");

        if (other.tag == "Player")
        {
            Luz.transform.rotation = Quaternion.Euler(-100f,0f,0f);
            audioSorce.enabled = false;
            Coll.transform.position = Coll.transform.position + new Vector3(-50, -50, 0);
        }
        
    }
}
