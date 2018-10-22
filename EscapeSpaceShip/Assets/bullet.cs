using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public playerHp p;
	public float Speed = 150.0f;
	//private Vector3 a;
	//public playerHp playerhp = 
	// Use this for initialization
	void Start () {
		
		//FindObjectOfType (PlayerController);
		p = GameObject.Find ("FPSController").GetComponent<playerHp>();

		//GetComponent<Rigidbody> ().AddForce (transform.up*Speed);
		GetComponent<Rigidbody> ().velocity = transform.up*5;
		//Destroy (gameObject, 10f);
	}
	/*void DoSlowmotion()
	{
		Time.timeScale = slowdownFacotr;
		Time.fixedDeltaTime = Time.timeScale * .02f;

	}*/
	// Update is called once per frame
	void Update () {
		/*print (GetComponent<Rigidbody> ().velocity.magnitude);
		if (GetComponent<Rigidbody> ().velocity.magnitude < 1)
		{
			Debug.Log ("느림");
			GetComponent<Rigidbody> ().AddForce (transform.up * Speed);
			//GetComponent<Rigidbody> ().velocity = Vector3 (3, 3, 3);

		}
		if (Input.GetButtonDown ("Fire2")) 
		{
			if (GetComponent<Rigidbody> ().velocity.magnitude < 2)
			{
				Debug.Log ("느림");Debug.Log ("수정");
				print (GetComponent<Rigidbody> ().velocity);
				GetComponent<Rigidbody> ().AddForce (transform.up * Speed);

			}
		}*/
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "player") {
			Hit ();
		} else if (other.tag == "Wall2") {
			Destroy (this.gameObject);
			Debug.Log ("벽맞음");
		}
		//
			//총알 파티션

	}
	void Hit()
	{
		p.hp = p.hp - 0.1f;
		Debug.Log ("총알맞음 ");
		//print (p.hp);
		Destroy (gameObject);
	}
}
