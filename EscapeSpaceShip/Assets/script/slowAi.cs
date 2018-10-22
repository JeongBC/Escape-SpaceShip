using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowAi : MonoBehaviour {

	public float slowdownFacotr = 0.05f;
	public float slowdownLength = 2f;


	void DoSlowmotion()
	{
		Time.timeScale = slowdownFacotr;
		Time.fixedDeltaTime = Time.timeScale * .02f;

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {
			DoSlowmotion ();
		}
	}
}
