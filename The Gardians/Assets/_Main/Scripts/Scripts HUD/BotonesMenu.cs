using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    public void BotonJugar()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void BotonSeleccion()
    {
        SceneManager.LoadScene("NivelSeleccion");
    }
    public void PrincipalMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void ExitButtom()
    {
        Application.Quit();
    }
}
