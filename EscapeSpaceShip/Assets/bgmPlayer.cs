using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmPlayer : MonoBehaviour { 

	static bgmPlayer instance = null;  //정적 변수를 이용
	// Use this for initialization 
	void Start () { 
		if (instance != null) { 
			DestroyObject (gameObject); 
			print ("Dulicate music player sef-detructing"); 
		} else { 
			instance = this; 
			DontDestroyOnLoad (gameObject); 
		} 
	}
}