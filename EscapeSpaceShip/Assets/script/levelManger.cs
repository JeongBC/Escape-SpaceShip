using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManger : MonoBehaviour {

	public AudioSource EndS;


	void OnTriggerEnter(Collider others)
	{
		EndS.Play ();
		Debug.Log ("Load level 2");
		Application.LoadLevel ("level2");

	}
}
