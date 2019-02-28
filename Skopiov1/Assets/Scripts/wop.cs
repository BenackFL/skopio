using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wop : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(11);
        }
		
	}
}
