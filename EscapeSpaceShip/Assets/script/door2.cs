using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class door2 : MonoBehaviour {

	public Animator anim;
	private AudioSource doorS;
	//public GameObject player;
	// Use this for initialization
	void Start () {
		doorS = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*if (Input.GetKeyDown (KeyCode.F)) 
		{
			Debug.Log ("aa");
			anim.SetBool ("character_nearby", true);
		}*/

	}

	void OnTriggerEnter(Collider others)
	{
		Debug.Log ("aa");
		doorS.Play ();
		anim.SetBool ("character_nearby", true);

	}

}

