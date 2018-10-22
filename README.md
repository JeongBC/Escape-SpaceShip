# Escape-SpaceShip
This game is Fps escape game. player use gun and time slow ability.

------------  

## Scene
__main menu__

<center><img src="https://user-images.githubusercontent.com/37068148/47288437-16428580-d631-11e8-9c86-8e969371c979.png" width="300" height="300"></center>

__stage 1__

enemy type - robot / use take gun script and 

<center><img src="https://user-images.githubusercontent.com/37068148/47288431-104ca480-d631-11e8-8f98-0f3ebe6b1e85.png" width="300" height="300"></center>


__stage 2__

enemy type - zombie , robot / use navagent that can chase player.

<center><img src="https://user-images.githubusercontent.com/37068148/47288424-09259680-d631-11e8-83d3-ffeb66c07bca.png" width="300" height="300"></center>

__end scene__

use shake camera script and change camera position script

<center><img src="https://user-images.githubusercontent.com/37068148/47288439-19d60c80-d631-11e8-8969-a72b16d80ceb.png" width="300" height="300"></center>

------------  
## Important code(script)
__slowMotion script__

this slow motion code active when player input right mouse down.
slow time first and fast time more and more to normal time speed.

```c#
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
	// Update is called once per frame
	void Update () 
	{
		Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
		Time.timeScale = Mathf.Clamp (Time.timeScale, 0f, 1f);
		if (Input.GetButtonDown ("Fire2")) {
			playerSound.PlayOneShot (slowSound);
			DoSlowmotion ();
		}
	}
}
```  

  ------------
## Play Game

### how to play
Move - W A S D /
Shoot gun - left mouse /
Ability - right mouse /
Jump - space

### Download link
Google Drive: [Download Game](https://drive.google.com/open?id=1poyoV48MA4aQPrW9cr7MWStEPFnwfU8q)

### Goal
1. Go ammor room and take weapon
2. Kill enemy
3. Escape from Space Shuttle

