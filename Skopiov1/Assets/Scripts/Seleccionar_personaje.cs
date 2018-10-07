using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Seleccionar_personaje : MonoBehaviour {

	private GameObject[] lista_personajes;
	private int index;

	// Use this for initialization
	private void Start()
		{

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
	}

	public void cambiar_escena()
	{
		PlayerPrefs.SetInt("personaje_elegido", index);
		SceneManager.LoadScene("HISTORIA");
	}

		
	// Update is called once per frame
	void Update () {
		
	}
}
