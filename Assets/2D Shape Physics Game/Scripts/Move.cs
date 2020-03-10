using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[DisallowMultipleComponent]
public class Move : MonoBehaviour {

	public float xspeed = -4f;
	public bool follow = false;

	// Update is called once per frame
	void Update ()
	{
		if (!follow)
			return;

		transform.Translate (Time.deltaTime * xspeed, 0, 0);
	}

	public void Follow(){
		follow = true;
	}

	public void Stop(){
		follow = false;
	}
}
