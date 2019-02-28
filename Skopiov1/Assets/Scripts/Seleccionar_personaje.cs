using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using MySql.Data.MySqlClient;
using UnityEngine.UI;

public class Seleccionar_personaje : MonoBehaviour {

	private GameObject[] lista_personajes;
	private int index;

    //abcdefghij
    //string comprados;
    //public int id_usuario;
    //public Text info;
    //public Text monedasInfo;
	// Use this for initialization
	private void Start()
		{
        //id_usuario = ControladorCambio.id_usuario2;
        index = PlayerPrefs.GetInt ("personaje_elegido");

		lista_personajes = new GameObject[transform.childCount];

			//se colocan en el array los personajes
			for(int i = 0; i < transform.childCount; i++)
				lista_personajes[i] = transform.GetChild(i).gameObject;

			//Se desactivan de la escena
			foreach(GameObject desactivar in lista_personajes)
				desactivar.SetActive(false);

			//Se activa el personaje elegido
			if(lista_personajes[index])
				lista_personajes[index].SetActive(true);

		}

	public void botonIzq()
	{
		//desactivar el modelo actual
		lista_personajes[index].SetActive(false);


		index--; //index=index-1;
		if (index < 0)
			index = lista_personajes.Length - 1;

		//activar el nuevo modelo
		lista_personajes[index].SetActive(true);
        //info.text = "";
    }

	public void botonDer()
	{
		//desactivar el modelo actual
		lista_personajes[index].SetActive(false);


		index++; //index=index-1;
		if (index == lista_personajes.Length)
			index = 0;

		//activar el nuevo modelo
		lista_personajes[index].SetActive(true);
        //info.text = "";
    }

	public void cambiar_escena()
	{

        /*string _log = "`usuarios` WHERE `Id_usuarios` LIKE '" + id_usuario + "'";
        AdminMYSQL _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
        MySqlDataReader Resultado = _adminMYSQL.Select(_log);
        Resultado.Read();
        comprados = Resultado.GetString(6);
        Resultado.Close();

        if (comprados.Contains(index.ToString()))
        {*/
            PlayerPrefs.SetInt("personaje_elegido", index);
            SceneManager.LoadScene("HISTORIA");
       /* }
        else
        {
            info.text = "Comprame :) !";
        }
	}

    public void comprar()
    {

        if (ControladorCambio.monedas2 >= 5)
        {

            string _log = "`usuarios` WHERE `Id_usuarios` LIKE '" + id_usuario + "'";
            AdminMYSQL _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
            MySqlDataReader Resultado = _adminMYSQL.Select(_log);
            Resultado.Read();
            comprados = Resultado.GetString(6);
            Resultado.Close();
            if (comprados.Contains(index.ToString()))
            {
                //Debug.Log("Ya existe este correo");
                info.text = "Ya tienes este personaje";

            }
            else
            {
                ControladorCambio.monedas2 = ControladorCambio.monedas2 - 5;
                comprados = ""+comprados + index.ToString();
                _log = "`usuarios` SET `personajes` = '" + comprados + "' WHERE `usuarios`.`Id_usuarios` = '" + id_usuario + "'";
                
                _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
                Resultado = _adminMYSQL.Actualiza(_log);
                Resultado.Close();

                _log = "`usuarios` SET `monedas_usuario` = '" + ControladorCambio.monedas2 + "' WHERE `usuarios`.`Id_usuarios` = '" + id_usuario + "'";
                
                _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
                Resultado = _adminMYSQL.Actualiza(_log);
                Resultado.Close();
                monedasInfo.text = ControladorCambio.monedas2.ToString();
                info.text = "Compraste este personaje :)";
                

            }

        }
        else
        {
            info.text = "No tienes suficientes monedas";
        }*/
	}
}
