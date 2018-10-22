# Escape-SpaceShip
This game is Fps escape game. player use gun and time slow ability.

## Scene
__main menu__

(image)

__stage 1__

enemy type - robot / use take gun script and 

(image)

__stage 2__

enemy type - zombie , robot / use navagent that can chase player.

(image)

__end scene__

use shake camera script and change camera position script

(image)

## Important code(script)
__slowMotion script__
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

