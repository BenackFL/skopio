using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MySql.Data.MySqlClient;

public class AdminMYSQL : MonoBehaviour {

    public string servidorBaseDatos;
    public string nombreBaseDatos;
    public string usuarioBaseDatos;
    public string contrasenaBaseDatos;

    private string datosConexion;
    private MySqlConnection conexion;
	// Use this for initialization
	void Start () {

        datosConexion = "Server=" + servidorBaseDatos + ";Database="+nombreBaseDatos+";Uid=" + usuarioBaseDatos+";Pwd="+contrasenaBaseDatos+";";

        ConectarConServidor();
	}
	
	private void ConectarConServidor()
    {
        conexion = new MySqlConnection(datosConexion);

        try
        {
            conexion.Open();
            Debug.Log("Conexion con DB correcta");
        }
        catch(MySqlException e)
        {
            Debug.LogError("Error: "+e);
        }
    }

    public MySqlDataReader Select(string _select)
    {
        MySqlCommand cmd = conexion.CreateCommand();
        cmd.CommandText = "SELECT * FROM " + _select;
        MySqlDataReader Resultado = cmd.ExecuteReader();
        return Resultado;
        
    }
}
