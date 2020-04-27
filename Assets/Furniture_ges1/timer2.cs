using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer2 : MonoBehaviour
{

    public Text contador;
    public Text fin;
    private float tiempo = 63f;

    private float ti = 98f;


    void Start()
    {

        contador.text = " " + tiempo;
        fin.enabled = false;

    }



    void Update()
    {
        ti -= Time.deltaTime;

        if (ti <= 0)
        {
            tiempo -= Time.deltaTime;


            contador.text = " " + tiempo.ToString("f0");


            if (tiempo <= 0)
            {
                contador.text = "0";


                fin.enabled = true;
                tiempo = 60f;

            }

            if (tiempo <= 59)
            {
                fin.enabled = false;
            }


        }

    }
}
