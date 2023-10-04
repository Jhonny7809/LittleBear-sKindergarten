using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private AudioSource _msrc;
    void Start()
    {
        _msrc = GetComponent<AudioSource>();
        _msrc.volume = 0f;
        StartCoroutine(Fade(true, _msrc, 2f, 0.07f));
        StartCoroutine(Fade(false, _msrc, 2f, 0f));
    }

    private void Update()
    {
        if (!_msrc.isPlaying)
        {
            _msrc.Play();
            StartCoroutine(Fade(true, _msrc, 2f, 0.07f));
            StartCoroutine(Fade(false, _msrc, 2f, 0f));
        }
    }

    // Update is called once per frame
    public IEnumerator Fade(bool fadeIn, AudioSource src, float duration, float targetVol)
    {
        if (!fadeIn)
        {
            double lenthOfSouce = (double)src.clip.samples / _msrc.clip.frequency;
            yield return new WaitForSecondsRealtime((float)(lenthOfSouce-duration));
        }

        float time = 0f;
        float startVol = src.volume;
        while (time < duration)
        {
            string fadeSituation = fadeIn ? "fadeIn" : "fadeOut";
            Debug.Log(fadeSituation);
            time += Time.deltaTime*0.1f;
            src.volume = Mathf.Lerp(startVol, targetVol, time / duration);
            yield return null;
        }

        yield break;
    }
}
