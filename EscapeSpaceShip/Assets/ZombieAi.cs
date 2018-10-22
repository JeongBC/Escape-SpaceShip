using UnityEngine;
using System.Collections;
using UnityEngine.Animations;
using UnityEngine.AI;

public class ZombieAi : MonoBehaviour {

	private Transform monstertr;
	public Transform playertr;
	private NavMeshAgent nvAgent;
	private Animator ZombieAni;
	public GameObject player;
	public playerHp p;
	// Use this for initialization

	void Start () {
		ZombieAni = gameObject.GetComponent<Animator> ();
		monstertr = gameObject.GetComponent<Transform> ();
		playertr = GameObject.FindWithTag ("player").GetComponent<Transform> ();
		nvAgent = gameObject.GetComponent<NavMeshAgent> ();
		player = GameObject.FindWithTag ("player");
		p = GameObject.Find ("FPSController").GetComponent<playerHp>();

	}
	void Update()
	{
		nvAgent.SetDestination (playertr.position);
		if (nvAgent.destination != transform.position) {
			Debug.Log ("이동");
			ZombieAni.SetFloat ("Speed", 1f);
		} else {
			ZombieAni.SetFloat ("Speed", 0);
			Debug.Log ("이동끝");
		}

	}
	void OnTriggerStay(Collider other)
	{
		Debug.Log ("충돌");

		//print (other.tag);
		if (other.tag == "player") {
			Debug.Log ("플레이어랑 충돌");
			ZombieAni.SetTrigger ("Attack");

			Invoke ("DamgePlayer", 1f);
		}
		else 
		{
			ZombieAni.SetTrigger ("Attack");
		}

	}
	void DamgePlayer()
	{
		p.hp = p.hp - 0.001f;
	}
}
	