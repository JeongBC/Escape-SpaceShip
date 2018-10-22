using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour {

	public GameObject howto;
	bool howtoB = false;
	public void onClickGameStart()
	{
		Application.LoadLevel ("main");
	// Use this for initializatio
	}
	public void onClickChallenge()
	{
		if (howtoB == false)
			howto.SetActive (true);
		else if (howtoB == true)
			howto.SetActive (false);
		// Use this for initializatio
	}
	public void onClickGameOver()
	{
		Debug.Log ("게임종료");
		Application.Quit ();
		//http://itleader.tistory.com/127
		// Use this for initializatio
	}
}