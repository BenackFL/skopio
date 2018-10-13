using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorCambio : MonoBehaviour {

    public Text idtxt;
    public Text monedastxt;

    //public int id;
    //public int monedas;

    public static int monedas2;
    public static int id_usuario2;

	// Use this for initialization
	void Start () {
        
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);    
    }
    // Update is called once per frame
    void Update () {
		
	}
    public void ActualizaDatosEntorno()
    {
       //login variable = GetComponent<login>();
        int.TryParse(idtxt.text, out id_usuario2);
        int.TryParse(monedastxt.text, out monedas2);
        //id_usuario2 = idtxt.text;
        //monedas2 = monedas.text;
    }
}
