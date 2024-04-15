using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostrarDatosUsuario : MonoBehaviour
{
    public TMP_Text nombreText; 
    public TMP_Text nombreText2;
    public TMP_Text correoText; 
    public TMP_Text contraseñaText; 

    void Start()
    {
        if (Manager.instance != null)
        {
            nombreText.text =  Manager.instance.nombre_usuarioActual;
            nombreText2.text =  Manager.instance.nombre_usuarioActual;
            correoText.text =  Manager.instance.correo_usuarioActual;
            contraseñaText.text = Manager.instance.contraseña_usuarioActual;
        }
    }
}
