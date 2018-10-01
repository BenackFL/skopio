using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiar_Personajes : MonoBehaviour {

	// control de los gameobjects
	public GameObject personaje1, personaje2;

	// esta variable contiene cual personaje esta seleccionado y activo
	int personajeActivo = 1;

	void Start () {

		// se activa el primer personaje y se desactivan los demas
		personaje1.gameObject.SetActive (true);
		personaje2.gameObject.SetActive (false);
	}

	// se cambian los personajes al presionar el boton
	public void cambiarPersonaje()
	{

		switch (personajeActivo) {

		// if el primer personaje esta activo
		case 1:

			// entonces el segundo personaje esta activo ahora
			personajeActivo = 2;

			// se desactiva el primer personaje y se activa el segundo
			personaje1.gameObject.SetActive (false);
			personaje2.gameObject.SetActive (true);
			break;

			// if el segundo personaje esta activo
		case 2:

			// entonces el primer personaje esta activo ahora
			personajeActivo = 1;

			// se desactiva el segundo personaje y se activa el primero
			personaje1.gameObject.SetActive (true);
			personaje2.gameObject.SetActive (false);
			break;
		}

	}
}

