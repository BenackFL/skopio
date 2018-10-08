using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour {

    public InputField usuariotxt;
    public InputField contrasenatxt;

    public InputField confirmaContratxt;
    public InputField correotxt;

    public Text info;

    public GameObject _registro;
    public GameObject _login;

     

    public void logear()
    {
        string _log = "`usuarios` WHERE `nombre_usuario` LIKE '"+usuariotxt.text + "' AND `pass_usuario` LIKE '" + contrasenatxt.text+"'";

        AdminMYSQL _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
        MySqlDataReader Resultado = _adminMYSQL.Select(_log);

        if (Resultado.HasRows)
        {
            Debug.Log("Login correcto");
            SceneManager.LoadScene("Menu");
        }
        else
        {
            //Debug.Log("Login incorrecto");
            info.text = "Datos incorrectos";
        }
        Resultado.Close();
    }

    public void RegistrarNuevoUsuario()
    {
        info.text = "";
        if (usuariotxt.text.Length >= 3 && usuariotxt.text.Length <= 12)
        {
            if (contrasenatxt.text == confirmaContratxt.text)
            {
                string _log = "`usuarios` WHERE `nombre_usuario` LIKE '" + usuariotxt.text + "'";
                AdminMYSQL _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
                MySqlDataReader Resultado = _adminMYSQL.Select(_log);

                if (Resultado.HasRows)
                {
                    //Debug.Log("Ya existe este usuario");
                    info.text = "Ya existe este usuario";
                    Resultado.Close();
                }
                else
                {
                    Resultado.Close();
                    _log = "`usuarios` WHERE `correo_usuario` LIKE '" + correotxt.text + "'";
                    _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
                    Resultado = _adminMYSQL.Select(_log);
                    if (Resultado.HasRows)
                    {
                        //Debug.Log("Ya existe este correo");
                        info.text = "Ya existe este correo";
                        Resultado.Close();
                    }
                    else
                    {




                        Resultado.Close();
                        _log = "`usuarios` (`Id_usuarios`, `nombre_usuario`, `pass_usuario`, `monedas_usuario`, `correo_usuario`) VALUES (NULL, '" + usuariotxt.text + "', '" + contrasenatxt.text + "', 0 , '" + correotxt.text + "')";
                        Resultado = _adminMYSQL.Insert(_log);
                        //Debug.Log("El usuario se creo correctamente");
                        Resultado.Close();
                        AbrirCerrarRegistro();
                    }
                }
            }
            else
            {
                //Debug.Log("Las contraseñas no coinciden");
                info.text = "Las contrasenas no coinciden";
            }
        }
        else
        {
            //Debug.Log("El usuario debe tener de 3 a 12 caracteres");
            info.text = "El usuario debe tener de 3 a 12 caracteres";
        }
    }

    public void AbrirCerrarRegistro()
    {
        info.text = "";
        if (_login.active)
        {
            _login.SetActive(false);
            _registro.SetActive(true);
        }
        else
        {
            _login.SetActive(true);
            _registro.SetActive(false); 
        }
    }
}
