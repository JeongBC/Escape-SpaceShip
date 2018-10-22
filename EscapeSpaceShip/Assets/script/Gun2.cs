
using UnityEngine;

public class Gun2 : MonoBehaviour {

	public float damage = 10f;
	public float range = 100f;
	public float imapctforce = 30f;
	public float fireRate = 15f;

	public Camera fpsCam;
	public ParticleSystem muzzlebrake;
	public GameObject impactEffect;
	public GameObject impactEffectAi;
	public GameObject impactEffectZombie;
	public AudioSource shootSound;
	public AudioClip shootingsound;
	public ZombieTarget zomtarget;

	//private float nextTimeToFire = 0f;
	// Use this for initialization
	void Start () {
		

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
			zomtarget = hit.transform.GetComponent<ZombieTarget> ();
			target target = hit.transform.GetComponent<target> ();
			/*if (target != null) 
			{
				zomtarget.TakeDamage (damage);
				target.TakeDamage (damage);
			}*/
			if (hit.rigidbody != null) 
			{
				hit.rigidbody.AddForce (-hit.normal * imapctforce);
			}
			GameObject impactGo = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));

			if (hit.transform.tag == "enemy")
			{
				Debug.Log ("로봇맞음");
				//GameObject impactGoAi = Instantiate (impactEffectAi, hit.point, Quaternion.LookRotation (hit.normal));
				target.TakeDamage (damage);
				//Destroy (impactGoAi,2f);
			}
			if (hit.transform.tag == "Zombie") 
			{
				Debug.Log ("좀비맞음");
				zomtarget.TakeDamage (damage);
			}
			Destroy (impactGo,2f);
		}

	}
}
