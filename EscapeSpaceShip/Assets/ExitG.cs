using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitG : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "player") 
		{
			Application.LoadLevel ("Ending");
		}
	}
}
