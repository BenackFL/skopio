using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorTienda : MonoBehaviour {
    public void CambiarEscena(string nombre)
    {

        SceneManager.LoadScene(nombre);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
