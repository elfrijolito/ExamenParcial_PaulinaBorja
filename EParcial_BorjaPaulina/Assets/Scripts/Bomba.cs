using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomba : MonoBehaviour
{
    public string escenaMuerte;

    //Bomba detecta jugador
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(escenaMuerte);
        }
    }
}
