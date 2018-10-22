using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getGun : MonoBehaviour {

	public GameObject gun;
	public GameObject fakeGun;
	public AudioSource reload;
	public GameObject goal1;
	public GameObject goal2;
	private bool GetGun =false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) 
		{

			gun.SetActive (true);
			Debug.Log ("총");
		}

	}
	void OnTriggerEnter(Collider others)
	{
		if (GetGun == false) 
		{
			goal1.SetActive (false);
			goal2.SetActive (true);
			GetGun = true;
			Debug.Log ("총");
			reload.Play ();
			gun.SetActive (true);
			Destroy (fakeGun);
		}
	}
}
