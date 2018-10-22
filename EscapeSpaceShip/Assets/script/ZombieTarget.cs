using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieTarget : MonoBehaviour {
	public AudioSource DeadS;
	public AudioClip DeadC;
	public float health = 20f;
	private Animator DeadAni;
	public NavMeshAgent rat;
	public ZombieAi ratAi;
	public GameObject impactEffectZombieHit;

	public void TakeDamage (float amount)
	{
		Debug.Log ("데지입음 좀");
		print (health);
		health -= amount;
		if (health <= 0f) 
		{
			DeadS.Play ();
			//DeadS.clip = DeadC;
			//Destroy (rat);

			Invoke ("Die", 1f);
		}
	}
	void Die()
	{
		
		Debug.Log("좀비 죽음");

		DeadAni.SetBool ("Dead", true);
		Destroy (rat);
		Destroy (ratAi);

	}
	// Use this for initialization
	void Start () {
		DeadAni = GetComponent<Animator> ();
		rat = GetComponent<NavMeshAgent> ();
		ratAi = GetComponent<ZombieAi> ();
		DeadS = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
