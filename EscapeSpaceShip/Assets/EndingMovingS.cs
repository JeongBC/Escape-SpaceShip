using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingMovingS : MonoBehaviour {

	public GameObject otherShip;
	private float rx = -20;
	bool move= false;
	// Use this for initialization
	void Start () {
		transform.Rotate (rx, 0, 0);
		Invoke ("MoveShuttle", 4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (move == true) {
			Debug.Log ("움직이기");
			float fMove = Time.deltaTime * 2.5f;
			float fMove2 = Time.deltaTime * 1f;
			otherShip.transform.Translate(Vector3.back * fMove2);
			otherShip.transform.Translate(Vector3.down * fMove2);
			transform.Translate (Vector3.forward * fMove);
			//Destroy (gameObject.GetComponent<EndingMovingS> (), 4f);
		}
	}
	void MoveShuttle()
	{
		move = true;

	}
}
