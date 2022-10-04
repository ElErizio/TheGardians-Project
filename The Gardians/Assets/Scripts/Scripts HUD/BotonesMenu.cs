using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    public void BotonJugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BotonSeleccion()
    {
        SceneManager.LoadScene("NivelSeleccion");
    }
}
