using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerHp : MonoBehaviour {

	public Slider HealthSlider;
	public float hp = 1f;
	//public float playerHealth = 50f;
	// Use this for initialization
	void Start () {
		HealthSlider = GameObject.Find ("Health").GetComponent<Slider> ();
		HealthSlider.value = hp;

	}
	
	// Update is called once per frame
	void Update () {
		HealthSlider = GameObject.Find ("Health").GetComponent<Slider> ();
		HealthSlider.value = hp;
		if (hp <= 0f) 
		{
			Debug.Log ("죽음");
		}
	}
}
