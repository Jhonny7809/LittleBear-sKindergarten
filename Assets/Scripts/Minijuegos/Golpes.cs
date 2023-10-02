using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpes : MonoBehaviour
{
    public GameObject golpes;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            golpes.SetActive(false);
        }
    }
}
