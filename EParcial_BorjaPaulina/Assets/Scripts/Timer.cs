using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI textoTimer;

    public string escenaMuerte;

    // Update is called once per frame
    void Update()
    {
        //función de cuenta hacia atrás
        timer -= Time.deltaTime;
        textoTimer.text = "" + timer.ToString("f0");

        //condición para cambio de escena
        if(timer <= 0)
        {
            SceneManager.LoadScene(escenaMuerte);
        }
    }
}
