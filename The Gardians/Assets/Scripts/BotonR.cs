using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonR : MonoBehaviour
{
    int escenasR;

    void Update()
    {

    }

    public void EscenasJuego()
    {
        // Codigo para hacer que escenasR tenga un valor Entero random entre 1 y 3 (El 4 está pueto porque el rango no incluye el valor maximo) 
        escenasR = Random.Range(1, 4);

        switch (escenasR)
        {
            // Codigo para poner cada unas de las escenas
            case 1: SceneManager.LoadScene("SampleScene");
                break;

            case 2: SceneManager.LoadScene("Level 2");
                break;

            case 3: SceneManager.LoadScene("Level 3");
                break;

        }
    }
}
