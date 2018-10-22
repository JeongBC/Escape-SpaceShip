using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {
	public ParticleSystem BombP;
	public GameObject impactEffect;
	public GameObject impactEffectAi;
	public AudioSource BombS;
	public AudioClip BombC;
	public float health = 50f;
	private Animator DeadAni;
	private robotAttackTrigger rat;
	public void TakeDamage (float amount)
	{
		
		health -= amount;
		if (health <= 0f) 
		{
			BombS.clip = BombC;
			Destroy (rat);

			Invoke ("Die", 1f);
		}
	}
	void Die()
	{
		BombS.Play ();
		BombP.Play ();
		DeadAni.SetBool ("Dead", true);

	}
	// Use this for initialization
	void Start () {
		DeadAni = GetComponent<Animator> ();
		rat = GetComponent<robotAttackTrigger> ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
