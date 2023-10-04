using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorcanvas : MonoBehaviour
{
    
        public float tiempoEspera ; // Tiempo en segundos para esperar antes de desactivar el Canvas
        public GameObject Panel;

        private void Start()
        {
            
            StartCoroutine(DesactivarCanvasDespuesDeEspera());
        }

        private IEnumerator DesactivarCanvasDespuesDeEspera()
        {
            yield return new WaitForSeconds(tiempoEspera);
        Panel.SetActive(false); // Desactivar el Canvas después del tiempo de espera
        
    }
}
