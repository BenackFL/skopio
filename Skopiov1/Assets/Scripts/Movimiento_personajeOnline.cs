using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;

public class Movimiento_personajeOnline :NetworkBehaviour {

    public LayerMask clickear;

    private NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();

        //m_MyText.text = "Hola";
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, clickear))
            {
                agent.SetDestination(hit.point);
            }
        }
    }


    }
