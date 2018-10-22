using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class goal2 : MonoBehaviour {

	public GameObject goalT;
	public GameObject goalL;
	// Use this for initialization
	void OnTriggerEnter(Collider others)
	{
		goalT.SetActive (false);
		goalL.SetActive (true);

	}
}
