using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TP_UI : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI resultado;
    string clave = "clave";

    // Start is called before the first frame update
    void Start()
    {
        resultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        if ( claveIngresada != clave)
        {
            resultado.text = "Acceso Denegado";
            inputClave.text = "";
        }
        else
        {
            resultado.text = "Acceso garantizado";
        }
    }
}
