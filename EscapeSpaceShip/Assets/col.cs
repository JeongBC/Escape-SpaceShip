using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour {

	public GameObject door;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("aaaa");
	}

	void OnTriggerEnter(Collider others)
	{
		Debug.Log ("aaaaaaaa");
	}
}
