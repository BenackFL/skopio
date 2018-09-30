using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class ContadorMonedas : MonoBehaviour {

    public string auxi;


    public Text changingText;
    public Text problema;
    //public TextMeshPro PreFab;

    public TextMeshPro m_Text;
    public TextMeshPro m_Text2;
    public TextMeshPro m_Text3;
    public TextMeshPro m_Text4;
    public TextMeshPro m_Text5;

    public static int contador_monedas = 0;
    public static int contador_problemas = 0;
    //Text m_MyText;

    int rando1 = 0, rando2 = 0, rando3 = 0, rando4 = 0, rando5 = 0, respuesta = 0, rno1, rno2, rno3, rno4, rno5;
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colision");

        //contador_monedas++;
        //changingText.text = "" + contador_monedas;

        //auxi = other.GetComponent<TextMeshPro>().ToString();
        auxi = other.gameObject.GetComponent<TextMeshPro>().GetParsedText().ToString();

        Debug.Log("Es " + auxi);
        if (auxi == respuesta.ToString())
        {
            Debug.Log("Acerto");
            m_Text.text = "";
            
            m_Text2.text = "";
            
            m_Text3.text = "";
            
            m_Text5.text = "";
            
            m_Text4.text = "";
            crearProblema();
        }
    }

    void Start () {
        if (contador_problemas == 0)
        {
            crearProblema();
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void crearProblema()
    {
        
        //Nivel 1, ligar score de Int art
        //Random randomizer = new Random();
        rando1 = Random.Range(1, 10);
        rando2 = Random.Range(1, 10);
        rando3 = Random.Range(1, 10);
        rando4 = Random.Range(1, 10);
        rando5 = Random.Range(1, 10);

        problema.text =  rando1+ "+" + rando2;

        respuesta = 0;
        respuesta = rando1 + rando2;
        rno1 = rando1 + rando3;
        rno2 = rando2 + rando3;
        rno3 = rando3 + rando4;
        rno4 = rando1 + rando5;
        rno5 = rando4 + rando2;


        //Respuestas
        m_Text = Instantiate(m_Text);

        m_Text2 = Instantiate(m_Text2);

        m_Text3 = Instantiate(m_Text3);

        m_Text5 = Instantiate(m_Text5);

        m_Text4 = Instantiate(m_Text4);

        //Ciclo problemas

        int randomsito=0;
        randomsito = Random.Range(1, 10);
        switch (randomsito)
        {
            case 1:
                m_Text.text = "" + respuesta;
                m_Text5.text = "" + rno1;
                break;
            case 2:
                m_Text2.text = "" + respuesta;
                m_Text4.text = "" + rno3;
                break;
            case 3:
                m_Text3.text = "" + respuesta;
                m_Text2.text = "" + rno2;
                break;
            case 4:
                m_Text4.text = "" + respuesta;
                m_Text.text = "" + rno5;
                break;
            case 5:
                m_Text5.text = "" + respuesta;
                m_Text2.text = "" + rno3;
                break;
            case 6:
                m_Text.text = "" + respuesta;
                m_Text2.text = "" + rno4;
                break;
            case 7:
                m_Text2.text = "" + respuesta;
                m_Text3.text = "" + rno2;
                break;
            case 8:
                m_Text3.text = "" + respuesta;
                m_Text5.text = "" + rno1;
                break;
            case 9:
                m_Text4.text = "" + respuesta;
                m_Text.text = "" + rno1;
                break;
            case 10:
                m_Text5.text = "" + respuesta;
                m_Text3.text = "" + rno3;
                break;
        }
        
        

        contador_problemas++;
        if (contador_problemas == 2)
        {//Terminar escena
            //SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
        }
        changingText.text = "" + contador_problemas;



    }

   
}
