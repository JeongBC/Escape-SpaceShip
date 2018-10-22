using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpHeal : MonoBehaviour {
	public playerHp PH;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		PH.hp = 1f;
		Destroy (this.gameObject);
	}
}
