using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarNivel : MonoBehaviour
{
    public string cargarEscena;

    // Update is called once per frame
    void Update()
    {
        //Cargar nive con teclado
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(cargarEscena);
        }
    }
}