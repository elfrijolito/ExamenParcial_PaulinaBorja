using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public string escenaInicio;

    // Update is called once per frame
    void Update()
    {
        //Reiniciar jeugo con teclado
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(escenaInicio);
        }
    }
}
