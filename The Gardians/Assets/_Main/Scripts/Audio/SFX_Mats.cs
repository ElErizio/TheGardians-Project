using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Mats : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("AcornProyectile"))
        {
            audioSource.Play();
        }
    }

}
