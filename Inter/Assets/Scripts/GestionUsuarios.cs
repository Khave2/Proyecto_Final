using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionUsuarios : MonoBehaviour
{
    [Header("Campos para registro")]
    public TMP_InputField[] campos_registro;

    [Header("Campos inicio")]
    public TMP_InputField[] campos_inicio;

    [Header("Sistema Alertas")]
    public string[] texto_alertas;

    public GameObject panel_Alertas;
    public TMP_Text alerta_Actual;

    public void RegistrarUsuario()
    {
        for (int i = 0; i < campos_registro.Length; i++)
        {
            //Primer alerta campos vacios
            if (string.IsNullOrEmpty(campos_registro[i].text))
            {
                panel_Alertas.SetActive(true);
                alerta_Actual.text = texto_alertas[0];
            }
            else
            {
                if (Manager.instance.usuarios.Contains(campos_registro[0].text))
                {
                    //Segunda Alerta
                    panel_Alertas.SetActive(true);
                    alerta_Actual.text = texto_alertas[1];
                }
                else
                {
                    Manager.instance.usuarios.Add(campos_registro[0].text);
                    Manager.instance.nombre_usuarioActual = campos_registro[0].text;
                    Manager.instance.correo_usuarioActual = campos_registro[1].text;
                    Manager.instance.contraseña_usuarioActual = campos_registro[2].text;
                    CambiarEscena cambioEscena = FindObjectOfType<CambiarEscena>();
                    cambioEscena.CambioEscena("Principal");
                }
            }

        }
    }

    public void IniciarSesion()
    {
        for (int i = 0; i < campos_inicio.Length; i++) 
        {
            if (string.IsNullOrEmpty(campos_inicio[i].text))
            {
                panel_Alertas.SetActive(true);
                alerta_Actual.text = texto_alertas[0];
            }
            else
            {
                if (Manager.instance.usuarios.Contains(campos_inicio[0].text))
                {
                    //Segunda Alerta
                    Manager.instance.usuarios.Add(campos_inicio[0].text);
                    Manager.instance.nombre_usuarioActual = campos_inicio[0].text;
                    Manager.instance.correo_usuarioActual = campos_inicio[1].text;
                    Manager.instance.contraseña_usuarioActual = campos_registro[2].text;

                    CambiarEscena cambioEscena = FindObjectOfType<CambiarEscena>();
                    cambioEscena.CambioEscena("Principal");
                }
                else
                {
                    //Tercera Alerta
                    panel_Alertas.SetActive(true);
                    alerta_Actual.text = texto_alertas[2];
                }
            }
        
        }
    }
}
