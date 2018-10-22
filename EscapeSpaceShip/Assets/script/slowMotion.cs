using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowMotion : MonoBehaviour {
	public AudioSource playerSound;
	public AudioClip slowSound;
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
//		print (Time.timeScale);
		//print (Time.deltaTime);
		Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
		Time.timeScale = Mathf.Clamp (Time.timeScale, 0f, 1f);
		if (Input.GetButtonDown ("Fire2")) {
			playerSound.PlayOneShot (slowSound);
			DoSlowmotion ();
		}
	}
}
