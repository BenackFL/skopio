using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Controlador : MonoBehaviour {

    public Text monedas;
    public void CambiarEscena(string nombre)
    {

        SceneManager.LoadScene(nombre);
    } 
	// Use this for initialization
	void Start () {
        monedas.text = ControladorCambio.monedas2.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
