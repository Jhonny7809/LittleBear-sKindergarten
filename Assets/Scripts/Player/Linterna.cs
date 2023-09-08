using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light LightFlashLight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (LightFlashLight.enabled == true)
            {
                LightFlashLight.enabled = false;
                Debug.Log("Apago");
            }
            else if (LightFlashLight.enabled == false)
            {
                LightFlashLight.enabled = true;
                Debug.Log("Prendio");
            }
        }
    }
}
//Codigo en el SpotLight, Instancias el spotlight en el codigo
