using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manzana : MonoBehaviour
{
    public int puntaje;
    public TextMeshProUGUI textopuntaje;

    //Manzana detecta jugador
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            puntaje++;
            textopuntaje.text = "" + puntaje.ToString();
        }
    }
}