using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    // Codigo para lanzar el nivel 1
    public void Botonjugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Botonsalir()
    {
        SceneManager.LoadScene("NivelSeleecion");
    }
}
