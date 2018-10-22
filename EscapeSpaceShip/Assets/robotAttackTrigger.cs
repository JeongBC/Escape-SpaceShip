using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotAttackTrigger : MonoBehaviour {

	public Animator AiAni1;
	//public transform gun;

	public GameObject bul;
	public Transform gun;
	public AudioSource ShootS;
	public AudioClip ShootC;
	//public GameObject gun;
	//public GameObject attackZone;
	// Use this for initialization
	void Start () {
		
		ShootS.clip = ShootC;

	}
	void Update()
	{
		//gun = GameObject.Find("bulletI");
		gun = transform.Find ("RigAss/RigSpine1/RigSpine2/RigSpine3/RigArmRightCollarbone/RigArmRight1/RigArmRight2/RigArmRight3/RigPistolRight/SciFiRifle(Clone)/bulletI");

	}
	void OnTriggerEnter(Collider ohter)
	{
		if (ohter.tag == "player")
		{
		Debug.Log ("공격준비");
		AttackAi ();
		InvokeRepeating ("FireR", 1f,1f);
		//StartCoroutine ("FireAi",1);
		}
	
	}
	void FireR ()
	{
		ShootS.Play ();
		Instantiate (bul, gun.transform	.position, gun.transform.rotation);
		AiAni1.SetTrigger ("Attack");
		Debug.Log ("공격2");
	}
	void AttackAi()
	{
		AiAni1.SetBool ("Aiming", true);

	}

	/*void OnTriggerStay(Collider ohter)
	{
		
		Debug.Log ("공격시작");
	
	}*/

	/*IEnumerator FireAi(float delayTime)
	{
		while (true) {
			yield return new WaitForSeconds (1f);
			FireR (delayTime);
			Debug.Log ("공격1");
			//Instantiate (bul, gun.transform.position, gun.transform.rotation);
			//FireR ();

		}
		//
	}*/

}
