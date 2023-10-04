using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
   public float duracion = 1.0f;

   public float magnitud = 1.0f;

   
    public IEnumerator Temblor()
    {
        Vector3 posicionoriginal = transform.localPosition;

        float elapsed = 0f;

        while (elapsed < duracion)
        {
            float x = Random.Range(.7f,1f) * magnitud;
            float y = Random.Range(.7f,1f) * magnitud;

            transform.localPosition = new Vector3(x, y, posicionoriginal.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = posicionoriginal;
    }



}
