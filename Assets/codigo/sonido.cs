using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour {


	GameObject[] pause;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Mute()
	{
		AudioListener.pause = !AudioListener.pause;

	}
}
