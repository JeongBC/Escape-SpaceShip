using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingEvent : MonoBehaviour {

	public GameObject FireB1;

	public GameObject FireB2;
	public GameObject FireB3;
	public GameObject FireB4;
	public Camera ca;
	public GameObject a;
	public GameObject b;
	// Use this for initialization
	void Start () {
		Invoke ("Bomb", 1.5f);
		Invoke ("CameraMove1", 4.5f);
	}
	
	// Update is called once per frame
	void Update () {
		//ca.transform.position=new Vector3 (-79, 3, -23);
	}
	void Bomb()
	{
		FireB1.SetActive (true);
	}
	void CameraMove1()
	{
		Debug.Log ("카메라움직임");
		ca.transform.position=new Vector3 (-90.2f, 4.6f, -26.86f);
		Invoke ("CameraMove2", 4f);
		//ca.transform.Rotate (5.515f, 41.102f, -0.026f);
	}
	void CameraMove2()
	{
		ca.transform.position = new Vector3 (-64, -2, -8);
		Invoke ("CameraMove3", 1.5f);
		//ca.transform.Rotate (42, 79, 0);
	}
	void CameraMove3()
	{
		
		ca.transform.position = new Vector3 (-74, 5, -14);
		Invoke ("Bomb2", 1f);

	}
	void Bomb2()
	{
		FireB2.SetActive (true);
		FireB3.SetActive (true);
		FireB4.SetActive (true);
		Invoke ("CameraMove4", 1f);
	}
	void CameraMove4()
	{
		a.SetActive (true);
		b.SetActive (true);
		ca.transform.position=new Vector3 (-93,2, -36);
	}
}
