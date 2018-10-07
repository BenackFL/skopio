using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;

public class login : MonoBehaviour {

    public InputField usuariotxt;
    public InputField contrasenatxt;
     

    public void logear()
    {
        string _log = "`usuarios` WHERE `nombre_usuario` LIKE '"+usuariotxt.text + "' AND `pass_usuario` LIKE '" + contrasenatxt.text+"'";

        AdminMYSQL _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
        MySqlDataReader Resultado = _adminMYSQL.Select(_log);

        if (Resultado.HasRows)
        {
            Debug.Log("Login correcto");
        }
        else
        {
            Debug.Log("Login incorrecto");
        }
        Resultado.Close();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
