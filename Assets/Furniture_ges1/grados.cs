using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class grados : MonoBehaviour {
    public Text texto;
    public Text texto2;
    public Text texto3;
    

    float s = 0;
    float ye = 0;
    float z = 0;
    double a = 0;
    double b = 0;
    double c = 0;
    //Vector3 positione;

    void Start () {
        //Camera.mainCamera.gameObject.transform.position


    }

    // Update is called once per frame
    void Update () {
        Camera camera = GetComponent<Camera>();

        s = camera.transform.eulerAngles.z;
        c = System.Math.Floor(s);
        texto2.text = " Y : " + c + " º";

        ye = camera.transform.eulerAngles.y;
        b = System.Math.Floor(ye);
        texto.text = "X : " + b + " º";

        z = camera.transform.eulerAngles.x;
        a=System.Math.Floor(z);
        texto3.text = "Y : " + a+ " º";
    }
}
