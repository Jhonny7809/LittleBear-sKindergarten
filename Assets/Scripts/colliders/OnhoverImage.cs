using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnhoverImage : MonoBehaviour
{
    public Image image;

    public void OnHover()
    {
        Debug.Log("Imagen");
        image.gameObject.SetActive(true);
    } 

    public void OnhoverExit()
    {
        image.gameObject.SetActive(false);
    }
}
