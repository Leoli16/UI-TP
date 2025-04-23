using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TP_UI : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    public TextMeshProUGUI resultado;
    string usuario = "usuario";
    string contraseña = "contraseña";

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
        string usuarioIngresado = username.text;
        string contraseñaIngresada = password.text;
        if ( usuarioIngresado != usuario || contraseñaIngresada != contraseña)
        {
            resultado.text = "Acceso Denegado";
            password.text = "";
        }
        else
        {
            resultado.text = "Acceso garantizado";
        }
    }
}
