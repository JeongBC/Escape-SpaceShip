
using UnityEngine;

public class Gun : MonoBehaviour {

	public float damage = 10f;
	public float range = 100f;
	public float imapctforce = 30f;
	public float fireRate = 15f;

	public Camera fpsCam;
	public ParticleSystem muzzlebrake;
	public GameObject impactEffect;
	public GameObject impactEffectAi;
	public AudioSource shootSound;
	public AudioClip shootingsound;

	public GameObject impactEffectZombieHit;
	//private float nextTimeToFire = 0f;
	// Use this for initialization
	void Start () {
		
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetButtonDown ("Fire1") /*&& Time.time >= nextTimeToFire*/) 
		{
			shootSound.clip = shootingsound;
			shootSound.Play ();
			//nextTimeToFire = Time.time + 1f / fireRate; //연사모드 
			Shoot ();
		}
			
	}
	void Shoot()
	{
		
		muzzlebrake.Play ();
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log (hit.transform.name);

			target target = hit.transform.GetComponent<target> ();
			if (target != null) 
			{
				
				target.TakeDamage (damage);
			}
			if (hit.rigidbody != null) 
			{
				hit.rigidbody.AddForce (-hit.normal * imapctforce);
			}
			GameObject impactGo = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));
		
			if (hit.transform.tag=="enemy")
			{
				Debug.Log ("로봇맞음맞음");
				GameObject impactGoAi = Instantiate (impactEffectAi, hit.point, Quaternion.LookRotation (hit.normal));
				Destroy (impactGoAi,2f);
			}
			if (hit.transform.tag == "Zombie") 
			{
				impactEffectZombieHit = Instantiate (impactEffectZombieHit, hit.point, Quaternion.LookRotation (hit.normal));
				Debug.Log ("좀비맞음");
			}
			Destroy (impactGo,2f);
		}

	}
}
